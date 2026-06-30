using CARMIN___BE.Entities;
using CARMIN___DAL.Interfaces;
using CARMIN___DAL.Sqlite;
using CARMIN___MAPPER.Mappers;
using Microsoft.Data.Sqlite;

namespace CARMIN___DAL.Repositories
{
    public class ImpresoraRepository : IRepository<Impresora>
    {
        private readonly SqliteConnectionFactory connectionFactory;

        public ImpresoraRepository(SqliteConnectionFactory? connectionFactory = null)
        {
            this.connectionFactory = connectionFactory ?? new SqliteConnectionFactory();
        }

        public int Guardar(Impresora entity)
        {
            const string sql = """
                INSERT INTO Impresoras (Modelo, Marca, Nombre, Tecnologia, TipoImpresora)
                VALUES (@Modelo, @Marca, @Nombre, @Tecnologia, @TipoImpresora);
                SELECT last_insert_rowid();
                """;

            using var connection = connectionFactory.Create();
            connection.Open();
            using var transaction = connection.BeginTransaction();

            using var command = new SqliteCommand(sql, connection, transaction);
            AddParameters(command, entity);
            var printerId = Convert.ToInt32(command.ExecuteScalar());

            GuardarPerfiles(connection, transaction, printerId, entity.PerfilesDeImpresion);

            if (entity is ImpresoraPorRendimiento impresoraPorRendimiento)
            {
                GuardarInsumos(connection, transaction, printerId, impresoraPorRendimiento.InsumosImpresora);
            }

            transaction.Commit();
            return printerId;
        }

        public bool Modificar(Impresora entity)
        {
            const string sql = """
                UPDATE Impresoras
                SET Modelo = @Modelo,
                    Marca = @Marca,
                    Nombre = @Nombre,
                    Tecnologia = @Tecnologia,
                    TipoImpresora = @TipoImpresora
                WHERE Id = @Id;
                """;

            using var connection = connectionFactory.Create();
            connection.Open();
            using var transaction = connection.BeginTransaction();

            using var command = new SqliteCommand(sql, connection, transaction);
            AddParameters(command, entity);
            command.Parameters.AddWithValue("@Id", entity.Id);
            var updated = command.ExecuteNonQuery() > 0;

            if (!updated)
            {
                transaction.Rollback();
                return false;
            }

            LimpiarRelaciones(connection, transaction, entity.Id);
            GuardarPerfiles(connection, transaction, entity.Id, entity.PerfilesDeImpresion);

            if (entity is ImpresoraPorRendimiento impresoraPorRendimiento)
            {
                GuardarInsumos(connection, transaction, entity.Id, impresoraPorRendimiento.InsumosImpresora);
            }

            transaction.Commit();
            return true;
        }

        public bool Eliminar(int id)
        {
            using var connection = connectionFactory.Create();
            connection.Open();
            using var transaction = connection.BeginTransaction();

            EliminarPerfilesAsociados(connection, transaction, id);

            using var command = new SqliteCommand("DELETE FROM Impresoras WHERE Id = @Id;", connection, transaction);
            command.Parameters.AddWithValue("@Id", id);
            var deleted = command.ExecuteNonQuery() > 0;

            transaction.Commit();
            return deleted;
        }

        public Impresora? ObtenerPorId(int id)
        {
            using var connection = connectionFactory.Create();
            connection.Open();

            using var command = new SqliteCommand("SELECT * FROM Impresoras WHERE Id = @Id;", connection);
            command.Parameters.AddWithValue("@Id", id);
            using var reader = command.ExecuteReader();

            if (!reader.Read())
            {
                return null;
            }

            var impresora = ImpresoraMapper.FromReader(reader);
            CargarRelaciones(connection, impresora);
            return impresora;
        }

        public List<Impresora> ListarTodo()
        {
            var items = new List<Impresora>();

            using var connection = connectionFactory.Create();
            connection.Open();
            using var command = new SqliteCommand("SELECT * FROM Impresoras ORDER BY Nombre;", connection);
            using var reader = command.ExecuteReader();

            while (reader.Read())
            {
                items.Add(ImpresoraMapper.FromReader(reader));
            }

            foreach (var impresora in items)
            {
                CargarRelaciones(connection, impresora);
            }

            return items;
        }

        public int ObtenerUltimoId()
        {
            using var connection = connectionFactory.Create();
            using var command = new SqliteCommand("SELECT COALESCE(MAX(Id), 0) FROM Impresoras;", connection);
            connection.Open();
            return Convert.ToInt32(command.ExecuteScalar());
        }

        private static void AddParameters(SqliteCommand command, Impresora entity)
        {
            command.Parameters.AddWithValue("@Modelo", entity.Modelo);
            command.Parameters.AddWithValue("@Marca", entity.Marca);
            command.Parameters.AddWithValue("@Nombre", entity.Nombre);
            command.Parameters.AddWithValue("@Tecnologia", entity.Tecnologia);
            command.Parameters.AddWithValue("@TipoImpresora", entity is ImpresoraPorRendimiento ? "Rendimiento" : "Calidad");
        }

        private static void GuardarPerfiles(
            SqliteConnection connection,
            SqliteTransaction transaction,
            int impresoraId,
            IEnumerable<PerfilImpresion> perfiles)
        {
            foreach (var perfil in perfiles)
            {
                const string insertPerfilSql = """
                    INSERT INTO PerfilesImpresion (Nombre, Precio, FactorMultiplicador, EsColor)
                    VALUES (@Nombre, @Precio, @FactorMultiplicador, @EsColor);
                    SELECT last_insert_rowid();
                    """;

                using var perfilCommand = new SqliteCommand(insertPerfilSql, connection, transaction);
                perfilCommand.Parameters.AddWithValue("@Nombre", perfil.Nombre);
                perfilCommand.Parameters.AddWithValue("@Precio", perfil.Precio);
                perfilCommand.Parameters.AddWithValue("@FactorMultiplicador", perfil.FactorMultiplicador);
                perfilCommand.Parameters.AddWithValue("@EsColor", perfil.EsColor);
                var perfilId = Convert.ToInt32(perfilCommand.ExecuteScalar());
                perfil.Id = perfilId;

                using var relationCommand = new SqliteCommand(
                    "INSERT INTO ImpresoraPerfilesImpresion (IdImpresora, IdPerfilImpresion) VALUES (@IdImpresora, @IdPerfilImpresion);",
                    connection,
                    transaction);
                relationCommand.Parameters.AddWithValue("@IdImpresora", impresoraId);
                relationCommand.Parameters.AddWithValue("@IdPerfilImpresion", perfilId);
                relationCommand.ExecuteNonQuery();
            }
        }

        private static void GuardarInsumos(
            SqliteConnection connection,
            SqliteTransaction transaction,
            int impresoraId,
            IEnumerable<InsumoImpresora> insumos)
        {
            foreach (var insumo in insumos)
            {
                using var command = new SqliteCommand(
                    "INSERT INTO ImpresoraInsumosImpresora (IdImpresora, IdInsumoImpresora) VALUES (@IdImpresora, @IdInsumoImpresora);",
                    connection,
                    transaction);
                command.Parameters.AddWithValue("@IdImpresora", impresoraId);
                command.Parameters.AddWithValue("@IdInsumoImpresora", insumo.Id);
                command.ExecuteNonQuery();
            }
        }

        private static void LimpiarRelaciones(SqliteConnection connection, SqliteTransaction transaction, int impresoraId)
        {
            EliminarPerfilesAsociados(connection, transaction, impresoraId);

            using var deleteInsumos = new SqliteCommand(
                "DELETE FROM ImpresoraInsumosImpresora WHERE IdImpresora = @IdImpresora;",
                connection,
                transaction);
            deleteInsumos.Parameters.AddWithValue("@IdImpresora", impresoraId);
            deleteInsumos.ExecuteNonQuery();
        }

        private static void EliminarPerfilesAsociados(SqliteConnection connection, SqliteTransaction transaction, int impresoraId)
        {
            var perfilIds = new List<int>();

            using (var selectCommand = new SqliteCommand(
                "SELECT IdPerfilImpresion FROM ImpresoraPerfilesImpresion WHERE IdImpresora = @IdImpresora;",
                connection,
                transaction))
            {
                selectCommand.Parameters.AddWithValue("@IdImpresora", impresoraId);
                using var reader = selectCommand.ExecuteReader();
                while (reader.Read())
                {
                    perfilIds.Add(reader.GetInt32(0));
                }
            }

            using (var deleteRelationCommand = new SqliteCommand(
                "DELETE FROM ImpresoraPerfilesImpresion WHERE IdImpresora = @IdImpresora;",
                connection,
                transaction))
            {
                deleteRelationCommand.Parameters.AddWithValue("@IdImpresora", impresoraId);
                deleteRelationCommand.ExecuteNonQuery();
            }

            foreach (var perfilId in perfilIds)
            {
                using var deletePerfilCommand = new SqliteCommand(
                    "DELETE FROM PerfilesImpresion WHERE Id = @Id;",
                    connection,
                    transaction);
                deletePerfilCommand.Parameters.AddWithValue("@Id", perfilId);
                deletePerfilCommand.ExecuteNonQuery();
            }
        }

        private static void CargarRelaciones(SqliteConnection connection, Impresora impresora)
        {
            impresora.PerfilesDeImpresion = ObtenerPerfiles(connection, impresora.Id);

            if (impresora is ImpresoraPorRendimiento impresoraPorRendimiento)
            {
                impresoraPorRendimiento.InsumosImpresora = ObtenerInsumos(connection, impresora.Id);
            }
        }

        private static List<PerfilImpresion> ObtenerPerfiles(SqliteConnection connection, int impresoraId)
        {
            var perfiles = new List<PerfilImpresion>();

            const string sql = """
                SELECT p.*
                FROM PerfilesImpresion p
                INNER JOIN ImpresoraPerfilesImpresion ip ON ip.IdPerfilImpresion = p.Id
                WHERE ip.IdImpresora = @IdImpresora
                ORDER BY p.Id;
                """;

            using var command = new SqliteCommand(sql, connection);
            command.Parameters.AddWithValue("@IdImpresora", impresoraId);
            using var reader = command.ExecuteReader();
            while (reader.Read())
            {
                perfiles.Add(PerfilImpresionMapper.FromReader(reader));
            }

            return perfiles;
        }

        private static List<InsumoImpresora> ObtenerInsumos(SqliteConnection connection, int impresoraId)
        {
            var insumos = new List<InsumoImpresora>();

            const string sql = """
                SELECT i.*
                FROM Insumos i
                INNER JOIN ImpresoraInsumosImpresora ii ON ii.IdInsumoImpresora = i.Id
                WHERE ii.IdImpresora = @IdImpresora
                ORDER BY i.Nombre;
                """;

            using var command = new SqliteCommand(sql, connection);
            command.Parameters.AddWithValue("@IdImpresora", impresoraId);
            using var reader = command.ExecuteReader();
            while (reader.Read())
            {
                if (InsumoMapper.FromReader(reader) is InsumoImpresora insumo)
                {
                    insumos.Add(insumo);
                }
            }

            return insumos;
        }
    }
}
