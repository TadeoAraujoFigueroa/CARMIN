using CARMIN___BE.Entities;
using CARMIN___DAL.Interfaces;
using CARMIN___DAL.Sqlite;
using CARMIN___MAPPER.Mappers;
using Microsoft.Data.Sqlite;

namespace CARMIN___DAL.Repositories
{
    public class IngresoRepository : IRepository<Ingreso>
    {
        private readonly SqliteConnectionFactory connectionFactory;

        public IngresoRepository(SqliteConnectionFactory? connectionFactory = null)
        {
            this.connectionFactory = connectionFactory ?? new SqliteConnectionFactory();
        }

        public int Guardar(Ingreso entity)
        {
            const string sql = """
                INSERT INTO Ingresos (Fecha, Monto)
                VALUES (@Fecha, @Monto);
                SELECT last_insert_rowid();
                """;

            using var connection = connectionFactory.Create();
            using var command = new SqliteCommand(sql, connection);
            command.Parameters.AddWithValue("@Fecha", entity.Fecha);
            command.Parameters.AddWithValue("@Monto", entity.Monto);
            connection.Open();
            return Convert.ToInt32(command.ExecuteScalar());
        }

        public bool Modificar(Ingreso entity)
        {
            const string sql = """
                UPDATE Ingresos
                SET Fecha = @Fecha,
                    Monto = @Monto
                WHERE Id = @Id;
                """;

            using var connection = connectionFactory.Create();
            using var command = new SqliteCommand(sql, connection);
            command.Parameters.AddWithValue("@Id", entity.Id);
            command.Parameters.AddWithValue("@Fecha", entity.Fecha);
            command.Parameters.AddWithValue("@Monto", entity.Monto);
            connection.Open();
            return command.ExecuteNonQuery() > 0;
        }

        public bool Eliminar(int id)
        {
            using var connection = connectionFactory.Create();
            using var command = new SqliteCommand("DELETE FROM Ingresos WHERE Id = @Id;", connection);
            command.Parameters.AddWithValue("@Id", id);
            connection.Open();
            return command.ExecuteNonQuery() > 0;
        }

        public Ingreso? ObtenerPorId(int id)
        {
            using var connection = connectionFactory.Create();
            using var command = new SqliteCommand("SELECT * FROM Ingresos WHERE Id = @Id;", connection);
            command.Parameters.AddWithValue("@Id", id);
            connection.Open();
            using var reader = command.ExecuteReader();
            return reader.Read() ? IngresoMapper.FromReader(reader) : null;
        }

        public List<Ingreso> ListarTodo()
        {
            var items = new List<Ingreso>();
            using var connection = connectionFactory.Create();
            using var command = new SqliteCommand("SELECT * FROM Ingresos ORDER BY Fecha DESC, Id DESC;", connection);
            connection.Open();
            using var reader = command.ExecuteReader();
            while (reader.Read())
            {
                items.Add(IngresoMapper.FromReader(reader));
            }
            return items;
        }

        public int ObtenerUltimoId()
        {
            using var connection = connectionFactory.Create();
            using var command = new SqliteCommand("SELECT COALESCE(MAX(Id), 0) FROM Ingresos;", connection);
            connection.Open();
            return Convert.ToInt32(command.ExecuteScalar());
        }
    }
}
