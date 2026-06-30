using CARMIN___BE.Entities;
using CARMIN___DAL.Interfaces;
using CARMIN___DAL.Sqlite;
using CARMIN___MAPPER.Mappers;
using Microsoft.Data.Sqlite;

namespace CARMIN___DAL.Repositories
{
    public class PedidoRepository : IRepository<Pedido>
    {
        private readonly SqliteConnectionFactory connectionFactory;

        public PedidoRepository(SqliteConnectionFactory? connectionFactory = null)
        {
            this.connectionFactory = connectionFactory ?? new SqliteConnectionFactory();
        }

        public int Guardar(Pedido entity)
        {
            const string sql = """
                INSERT INTO Pedidos
                    (Nombre, IdCliente, IdPresupuesto, Estado, EstadoDePago, FechaDeEntrega, Importe, TiempoTotalDeProduccion)
                VALUES
                    (@Nombre, @IdCliente, @IdPresupuesto, @Estado, @EstadoDePago, @FechaDeEntrega, @Importe, @TiempoTotalDeProduccion);
                SELECT last_insert_rowid();
                """;

            using var connection = connectionFactory.Create();
            using var command = new SqliteCommand(sql, connection);
            AddParameters(command, entity);
            connection.Open();
            return Convert.ToInt32(command.ExecuteScalar());
        }

        public bool Modificar(Pedido entity)
        {
            const string sql = """
                UPDATE Pedidos
                SET Nombre = @Nombre,
                    IdCliente = @IdCliente,
                    IdPresupuesto = @IdPresupuesto,
                    Estado = @Estado,
                    EstadoDePago = @EstadoDePago,
                    FechaDeEntrega = @FechaDeEntrega,
                    Importe = @Importe,
                    TiempoTotalDeProduccion = @TiempoTotalDeProduccion
                WHERE Id = @Id;
                """;

            using var connection = connectionFactory.Create();
            using var command = new SqliteCommand(sql, connection);
            command.Parameters.AddWithValue("@Id", entity.Id);
            AddParameters(command, entity);
            connection.Open();
            return command.ExecuteNonQuery() > 0;
        }

        public bool Eliminar(int id)
        {
            using var connection = connectionFactory.Create();
            using var command = new SqliteCommand("DELETE FROM Pedidos WHERE Id = @Id;", connection);
            command.Parameters.AddWithValue("@Id", id);
            connection.Open();
            return command.ExecuteNonQuery() > 0;
        }

        public Pedido? ObtenerPorId(int id)
        {
            using var connection = connectionFactory.Create();
            using var command = new SqliteCommand("SELECT * FROM Pedidos WHERE Id = @Id;", connection);
            command.Parameters.AddWithValue("@Id", id);
            connection.Open();
            using var reader = command.ExecuteReader();
            return reader.Read() ? PedidoMapper.FromReader(reader) : null;
        }

        public List<Pedido> ListarTodo()
        {
            var items = new List<Pedido>();
            using var connection = connectionFactory.Create();
            using var command = new SqliteCommand("SELECT * FROM Pedidos ORDER BY Id DESC;", connection);
            connection.Open();
            using var reader = command.ExecuteReader();
            while (reader.Read())
            {
                items.Add(PedidoMapper.FromReader(reader));
            }
            return items;
        }

        public int ObtenerUltimoId()
        {
            using var connection = connectionFactory.Create();
            using var command = new SqliteCommand("SELECT COALESCE(MAX(Id), 0) FROM Pedidos;", connection);
            connection.Open();
            return Convert.ToInt32(command.ExecuteScalar());
        }

        private static void AddParameters(SqliteCommand command, Pedido entity)
        {
            command.Parameters.AddWithValue("@Nombre", entity.Nombre);
            command.Parameters.AddWithValue("@IdCliente", entity.IdCliente);
            command.Parameters.AddWithValue("@IdPresupuesto", entity.IdPresupuesto);
            command.Parameters.AddWithValue("@Estado", entity.Estado);
            command.Parameters.AddWithValue("@EstadoDePago", entity.EstadoDePago);
            command.Parameters.AddWithValue("@FechaDeEntrega", entity.FechaDeEntrega);
            command.Parameters.AddWithValue("@Importe", entity.Importe);
            command.Parameters.AddWithValue("@TiempoTotalDeProduccion", entity.TiempoTotalDeProduccion);
        }
    }
}
