using Microsoft.Extensions.Configuration;
using Microsoft.Data.Sqlite;

namespace CARMIN___DAL.Configuration
{
    public static class SqliteConfiguration
    {
        private const string ApplicationDataDirectoryName = "CARMIN";
        private static readonly Lazy<IConfiguration> ConfigurationRoot = new(BuildConfiguration);

        public static string GetConnectionString()
        {
            var connectionString = GetConfiguredConnectionString();
            var builder = new SqliteConnectionStringBuilder(connectionString);
            builder.DataSource = GetDatabaseFilePath(builder.DataSource);

            return builder.ToString();
        }

        public static string GetDatabaseFilePath()
        {
            var builder = new SqliteConnectionStringBuilder(GetConfiguredConnectionString());

            if (string.IsNullOrWhiteSpace(builder.DataSource))
            {
                throw new InvalidOperationException(
                    "La cadena de conexion SQLite no contiene un Data Source valido.");
            }

            return GetDatabaseFilePath(builder.DataSource);
        }

        private static string GetConfiguredConnectionString()
        {
            var connectionString = ConfigurationRoot.Value.GetConnectionString("CarminDb");

            if (string.IsNullOrWhiteSpace(connectionString))
            {
                throw new InvalidOperationException(
                    "No se encontro la cadena de conexion 'ConnectionStrings:CarminDb' en appsettings.json.");
            }

            return connectionString;
        }

        public static string GetScriptsDirectoryPath()
        {
            return GetInstallationPath("ARCHIVOS", "sql");
        }

        public static string GetBundledDatabaseFilePath()
        {
            return GetInstallationPath("ARCHIVOS", "sqlite", "carmin.db");
        }

        private static string GetDatabaseFilePath(string configuredPath)
        {
            if (Path.IsPathRooted(configuredPath))
            {
                return Path.GetFullPath(configuredPath);
            }

            var localApplicationData = Environment.GetFolderPath(
                Environment.SpecialFolder.LocalApplicationData);

            return Path.GetFullPath(Path.Combine(
                localApplicationData,
                ApplicationDataDirectoryName,
                configuredPath));
        }

        private static string GetInstallationPath(params string[] segments)
        {
            return Path.GetFullPath(Path.Combine(
                [AppDomain.CurrentDomain.BaseDirectory, .. segments]));
        }

        private static IConfiguration BuildConfiguration()
        {
            return new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .Build();
        }
    }
}
