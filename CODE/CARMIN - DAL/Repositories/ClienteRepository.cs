using CARMIN___BE.Entities;
using CARMIN___DAL.Interfaces;
using CARMIN___DAL.Sqlite;
using CARMIN___MAPPER.Mappers;
using Microsoft.Data.Sqlite;

namespace CARMIN___DAL.Repositories
{
    public class ClienteRepository : IRepository<Cliente>
    {
        private readonly SqliteConnectionFactory connectionFactory;

        public ClienteRepository(SqliteConnectionFactory? connectionFactory = null)
        {
            this.connectionFactory = connectionFactory ?? new SqliteConnectionFactory();
        }

        public int Guardar(Cliente entity)
        {
            const string sql = """
                INSERT INTO Clientes (Nombre, Telefono, Direccion)
                VALUES (@Nombre, @Telefono, @Direccion);
                SELECT last_insert_rowid();
                """;

            using var connection = connectionFactory.Create();
            using var command = new SqliteCommand(sql, connection);
            AddParameters(command, entity);
            connection.Open();
            return Convert.ToInt32(command.ExecuteScalar());
        }

        public bool Modificar(Cliente entity)
        {
            const string sql = """
                UPDATE Clientes
                SET Nombre = @Nombre,
                    Telefono = @Telefono,
                    Direccion = @Direccion
                WHERE Id = @Id;
                """;

            using var connection = connectionFactory.Create();
            using var command = new SqliteCommand(sql, connection);
            AddParameters(command, entity);
            command.Parameters.AddWithValue("@Id", entity.Id);
            connection.Open();
            return command.ExecuteNonQuery() > 0;
        }

        public bool Eliminar(int id)
        {
            using var connection = connectionFactory.Create();
            using var command = new SqliteCommand("DELETE FROM Clientes WHERE Id = @Id;", connection);
            command.Parameters.AddWithValue("@Id", id);
            connection.Open();
            return command.ExecuteNonQuery() > 0;
        }

        public Cliente? ObtenerPorId(int id)
        {
            using var connection = connectionFactory.Create();
            using var command = new SqliteCommand("SELECT Id, Nombre, Telefono, Direccion FROM Clientes WHERE Id = @Id;", connection);
            command.Parameters.AddWithValue("@Id", id);
            connection.Open();
            using var reader = command.ExecuteReader();
            return reader.Read() ? ClienteMapper.FromReader(reader) : null;
        }

        public List<Cliente> ListarTodo()
        {
            var items = new List<Cliente>();
            using var connection = connectionFactory.Create();
            using var command = new SqliteCommand("SELECT Id, Nombre, Telefono, Direccion FROM Clientes ORDER BY Nombre;", connection);
            connection.Open();
            using var reader = command.ExecuteReader();
            while (reader.Read())
            {
                items.Add(ClienteMapper.FromReader(reader));
            }

            return items;
        }

        public int ObtenerUltimoId()
        {
            using var connection = connectionFactory.Create();
            using var command = new SqliteCommand("SELECT COALESCE(MAX(Id), 0) FROM Clientes;", connection);
            connection.Open();
            return Convert.ToInt32(command.ExecuteScalar());
        }

        private static void AddParameters(SqliteCommand command, Cliente entity)
        {
            command.Parameters.AddWithValue("@Nombre", entity.Nombre);
            command.Parameters.AddWithValue("@Telefono", (object?)entity.Telefono ?? DBNull.Value);
            command.Parameters.AddWithValue("@Direccion", (object?)entity.Direccion ?? DBNull.Value);
        }
    }
}
