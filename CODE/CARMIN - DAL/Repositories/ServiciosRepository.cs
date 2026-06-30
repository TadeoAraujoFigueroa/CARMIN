using CARMIN___BE.Entities;
using CARMIN___DAL.Interfaces;
using CARMIN___DAL.Sqlite;
using CARMIN___MAPPER.Mappers;
using Microsoft.Data.Sqlite;

namespace CARMIN___DAL.Repositories
{
    public class ServiciosRepository : IRepository<Servicios>
    {
        private readonly SqliteConnectionFactory connectionFactory;

        public ServiciosRepository(SqliteConnectionFactory? connectionFactory = null)
        {
            this.connectionFactory = connectionFactory ?? new SqliteConnectionFactory();
        }

        public int Guardar(Servicios entity)
        {
            const string sql = """
                INSERT INTO Servicios (Nombre, ImporteMensual)
                VALUES (@Nombre, @ImporteMensual);
                SELECT last_insert_rowid();
                """;

            using var connection = connectionFactory.Create();
            using var command = new SqliteCommand(sql, connection);
            command.Parameters.AddWithValue("@Nombre", entity.Nombre);
            command.Parameters.AddWithValue("@ImporteMensual", entity.ImporteMensual);
            connection.Open();
            return Convert.ToInt32(command.ExecuteScalar());
        }

        public bool Modificar(Servicios entity)
        {
            const string sql = """
                UPDATE Servicios
                SET Nombre = @Nombre,
                    ImporteMensual = @ImporteMensual
                WHERE Id = @Id;
                """;

            using var connection = connectionFactory.Create();
            using var command = new SqliteCommand(sql, connection);
            command.Parameters.AddWithValue("@Id", entity.Id);
            command.Parameters.AddWithValue("@Nombre", entity.Nombre);
            command.Parameters.AddWithValue("@ImporteMensual", entity.ImporteMensual);
            connection.Open();
            return command.ExecuteNonQuery() > 0;
        }

        public bool Eliminar(int id)
        {
            using var connection = connectionFactory.Create();
            using var command = new SqliteCommand("DELETE FROM Servicios WHERE Id = @Id;", connection);
            command.Parameters.AddWithValue("@Id", id);
            connection.Open();
            return command.ExecuteNonQuery() > 0;
        }

        public Servicios? ObtenerPorId(int id)
        {
            using var connection = connectionFactory.Create();
            using var command = new SqliteCommand("SELECT * FROM Servicios WHERE Id = @Id;", connection);
            command.Parameters.AddWithValue("@Id", id);
            connection.Open();
            using var reader = command.ExecuteReader();
            return reader.Read() ? ServiciosMapper.FromReader(reader) : null;
        }

        public List<Servicios> ListarTodo()
        {
            var items = new List<Servicios>();
            using var connection = connectionFactory.Create();
            using var command = new SqliteCommand("SELECT * FROM Servicios ORDER BY Nombre;", connection);
            connection.Open();
            using var reader = command.ExecuteReader();
            while (reader.Read())
            {
                items.Add(ServiciosMapper.FromReader(reader));
            }
            return items;
        }

        public int ObtenerUltimoId()
        {
            using var connection = connectionFactory.Create();
            using var command = new SqliteCommand("SELECT COALESCE(MAX(Id), 0) FROM Servicios;", connection);
            connection.Open();
            return Convert.ToInt32(command.ExecuteScalar());
        }
    }
}
