using CARMIN___BE.Entities;
using CARMIN___DAL.Interfaces;
using CARMIN___DAL.Sqlite;
using CARMIN___MAPPER.Mappers;
using Microsoft.Data.Sqlite;

namespace CARMIN___DAL.Repositories
{
    public class GastoRepository : IRepository<Gasto>
    {
        private readonly SqliteConnectionFactory connectionFactory;

        public GastoRepository(SqliteConnectionFactory? connectionFactory = null)
        {
            this.connectionFactory = connectionFactory ?? new SqliteConnectionFactory();
        }

        public int Guardar(Gasto entity)
        {
            const string sql = """
                INSERT INTO Gastos (Fecha, Monto, Descripcion)
                VALUES (@Fecha, @Monto, @Descripcion);
                SELECT last_insert_rowid();
                """;

            using var connection = connectionFactory.Create();
            using var command = new SqliteCommand(sql, connection);
            command.Parameters.AddWithValue("@Fecha", entity.Fecha);
            command.Parameters.AddWithValue("@Monto", entity.Monto);
            command.Parameters.AddWithValue("@Descripcion", (object?)entity.Descripcion ?? DBNull.Value);
            connection.Open();
            return Convert.ToInt32(command.ExecuteScalar());
        }

        public bool Modificar(Gasto entity)
        {
            const string sql = """
                UPDATE Gastos
                SET Fecha = @Fecha,
                    Monto = @Monto,
                    Descripcion = @Descripcion
                WHERE Id = @Id;
                """;

            using var connection = connectionFactory.Create();
            using var command = new SqliteCommand(sql, connection);
            command.Parameters.AddWithValue("@Id", entity.Id);
            command.Parameters.AddWithValue("@Fecha", entity.Fecha);
            command.Parameters.AddWithValue("@Monto", entity.Monto);
            command.Parameters.AddWithValue("@Descripcion", (object?)entity.Descripcion ?? DBNull.Value);
            connection.Open();
            return command.ExecuteNonQuery() > 0;
        }

        public bool Eliminar(int id)
        {
            using var connection = connectionFactory.Create();
            using var command = new SqliteCommand("DELETE FROM Gastos WHERE Id = @Id;", connection);
            command.Parameters.AddWithValue("@Id", id);
            connection.Open();
            return command.ExecuteNonQuery() > 0;
        }

        public Gasto? ObtenerPorId(int id)
        {
            using var connection = connectionFactory.Create();
            using var command = new SqliteCommand("SELECT * FROM Gastos WHERE Id = @Id;", connection);
            command.Parameters.AddWithValue("@Id", id);
            connection.Open();
            using var reader = command.ExecuteReader();
            return reader.Read() ? GastoMapper.FromReader(reader) : null;
        }

        public List<Gasto> ListarTodo()
        {
            var items = new List<Gasto>();
            using var connection = connectionFactory.Create();
            using var command = new SqliteCommand("SELECT * FROM Gastos ORDER BY Fecha DESC, Id DESC;", connection);
            connection.Open();
            using var reader = command.ExecuteReader();
            while (reader.Read())
            {
                items.Add(GastoMapper.FromReader(reader));
            }
            return items;
        }

        public int ObtenerUltimoId()
        {
            using var connection = connectionFactory.Create();
            using var command = new SqliteCommand("SELECT COALESCE(MAX(Id), 0) FROM Gastos;", connection);
            connection.Open();
            return Convert.ToInt32(command.ExecuteScalar());
        }
    }
}
