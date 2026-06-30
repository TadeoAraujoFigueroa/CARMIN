using System.Text;
using System.Security.Cryptography;
using CARMIN___DAL.Configuration;
using CARMIN___DAL.Sqlite;
using Microsoft.Data.Sqlite;

namespace CARMIN___DAL.Initialization
{
    public class SqliteDatabaseInitializer
    {
        private const string SqliteHeader = "SQLite format 3\0";
        private const string SchemaMigrationsTableName = "__SchemaMigrations";

        private readonly SqliteConnectionFactory connectionFactory;

        public SqliteDatabaseInitializer(SqliteConnectionFactory? connectionFactory = null)
        {
            this.connectionFactory = connectionFactory ?? new SqliteConnectionFactory();
        }

        public void EnsureInitialized()
        {
            var databaseFilePath = SqliteConfiguration.GetDatabaseFilePath();
            var scriptsDirectory = SqliteConfiguration.GetScriptsDirectoryPath();

            EnsureDirectories(databaseFilePath, scriptsDirectory);
            CopyBundledDatabaseIfNeeded(databaseFilePath);
            EnsureHealthyDatabaseFile(databaseFilePath);
            RunScripts(scriptsDirectory, databaseFilePath);
        }

        private static void CopyBundledDatabaseIfNeeded(string databaseFilePath)
        {
            if (File.Exists(databaseFilePath))
            {
                return;
            }

            var bundledDatabaseFilePath = SqliteConfiguration.GetBundledDatabaseFilePath();

            if (File.Exists(bundledDatabaseFilePath))
            {
                File.Copy(bundledDatabaseFilePath, databaseFilePath);
            }
        }

        private static void EnsureDirectories(string databaseFilePath, string scriptsDirectory)
        {
            var databaseDirectory = Path.GetDirectoryName(databaseFilePath);
            if (!string.IsNullOrWhiteSpace(databaseDirectory))
            {
                Directory.CreateDirectory(databaseDirectory);
            }

            if (!Directory.Exists(scriptsDirectory))
            {
                throw new DirectoryNotFoundException(
                    $"No se encontro la carpeta de scripts SQLite: {scriptsDirectory}");
            }
        }

        private static void EnsureHealthyDatabaseFile(string databaseFilePath)
        {
            if (!File.Exists(databaseFilePath))
            {
                return;
            }

            if (new FileInfo(databaseFilePath).Length == 0)
            {
                File.Delete(databaseFilePath);
                return;
            }

            using var stream = File.OpenRead(databaseFilePath);
            if (stream.Length < SqliteHeader.Length)
            {
                QuarantineCorruptedDatabase(databaseFilePath);
                return;
            }

            var headerBuffer = new byte[SqliteHeader.Length];
            var bytesRead = stream.Read(headerBuffer, 0, headerBuffer.Length);
            var header = Encoding.ASCII.GetString(headerBuffer, 0, bytesRead);

            if (!string.Equals(header, SqliteHeader, StringComparison.Ordinal))
            {
                QuarantineCorruptedDatabase(databaseFilePath);
            }
        }

        private void RunScripts(string scriptsDirectory, string databaseFilePath)
        {
            try
            {
                ExecuteScripts(scriptsDirectory);
            }
            catch (SqliteException ex) when (ex.SqliteErrorCode == 26)
            {
                QuarantineCorruptedDatabase(databaseFilePath);
                ExecuteScripts(scriptsDirectory);
            }
        }

        private void ExecuteScripts(string scriptsDirectory)
        {
            using var connection = connectionFactory.Create();
            connection.Open();

            EnsureSchemaMigrationsTable(connection);

            foreach (var scriptPath in Directory.GetFiles(scriptsDirectory, "*.sql").OrderBy(path => path))
            {
                var scriptContent = File.ReadAllText(scriptPath);

                if (string.IsNullOrWhiteSpace(scriptContent))
                {
                    continue;
                }

                ApplyScriptIfNeeded(connection, scriptPath, scriptContent);
            }
        }

        private static void EnsureSchemaMigrationsTable(SqliteConnection connection)
        {
            var script = $"""
                CREATE TABLE IF NOT EXISTS {SchemaMigrationsTableName}
                (
                    ScriptName TEXT PRIMARY KEY,
                    Checksum TEXT NOT NULL,
                    AppliedAt TEXT NOT NULL
                );
                """;

            using var command = new SqliteCommand(script, connection);
            command.ExecuteNonQuery();
        }

        private static void ApplyScriptIfNeeded(
            SqliteConnection connection,
            string scriptPath,
            string scriptContent)
        {
            var scriptName = Path.GetFileName(scriptPath);
            var checksum = ComputeChecksum(scriptContent);
            var appliedChecksum = GetAppliedChecksum(connection, scriptName);

            if (appliedChecksum is not null)
            {
                if (!string.Equals(appliedChecksum, checksum, StringComparison.Ordinal))
                {
                    throw new InvalidOperationException(
                        $"El script '{scriptName}' ya fue aplicado con una version distinta. " +
                        "Para cambios de esquema seguros, cree un nuevo archivo .sql en lugar de modificar uno existente.");
                }

                return;
            }

            using var transaction = connection.BeginTransaction();

            using (var command = new SqliteCommand(scriptContent, connection, transaction))
            {
                command.ExecuteNonQuery();
            }

            const string insertMigration = """
                INSERT INTO __SchemaMigrations (ScriptName, Checksum, AppliedAt)
                VALUES (@ScriptName, @Checksum, @AppliedAt);
                """;

            using (var command = new SqliteCommand(insertMigration, connection, transaction))
            {
                command.Parameters.AddWithValue("@ScriptName", scriptName);
                command.Parameters.AddWithValue("@Checksum", checksum);
                command.Parameters.AddWithValue("@AppliedAt", DateTime.UtcNow.ToString("O"));
                command.ExecuteNonQuery();
            }

            transaction.Commit();
        }

        private static string? GetAppliedChecksum(SqliteConnection connection, string scriptName)
        {
            var script = $"""
                SELECT Checksum
                FROM {SchemaMigrationsTableName}
                WHERE ScriptName = @ScriptName
                LIMIT 1;
                """;

            using var command = new SqliteCommand(script, connection);
            command.Parameters.AddWithValue("@ScriptName", scriptName);

            return command.ExecuteScalar() as string;
        }

        private static string ComputeChecksum(string content)
        {
            var bytes = Encoding.UTF8.GetBytes(content);
            var hash = SHA256.HashData(bytes);

            return Convert.ToHexString(hash);
        }

        private static void QuarantineCorruptedDatabase(string databaseFilePath)
        {
            if (!File.Exists(databaseFilePath))
            {
                return;
            }

            var corruptCopyPath = $"{databaseFilePath}.corrupt-{DateTime.Now:yyyyMMdd-HHmmss}";
            File.Move(databaseFilePath, corruptCopyPath, overwrite: true);
        }
    }
}
