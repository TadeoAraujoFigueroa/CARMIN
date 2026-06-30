using CARMIN___BE.Entities;
using CARMIN___DAL.Interfaces;
using CARMIN___DAL.Sqlite;
using CARMIN___MAPPER.Mappers;
using Microsoft.Data.Sqlite;

namespace CARMIN___DAL.Repositories
{
    public class PresupuestoRepository : IRepository<Presupuesto>
    {
        private readonly SqliteConnectionFactory connectionFactory;

        public PresupuestoRepository(SqliteConnectionFactory? connectionFactory = null)
        {
            this.connectionFactory = connectionFactory ?? new SqliteConnectionFactory();
        }

        public int Guardar(Presupuesto entity)
        {
            const string sql = """
                INSERT INTO Presupuestos
                (Nombre, CostoTotal, MontoTotal, Descuento, HorasDisenio, HorasTrabajo, MargenGanancia, MargenMerma, MargenMaquinaria, Recargo)
                VALUES
                (@Nombre, @CostoTotal, @MontoTotal, @Descuento, @HorasDisenio, @HorasTrabajo, @MargenGanancia, @MargenMerma, @MargenMaquinaria, @Recargo);
                SELECT last_insert_rowid();
                """;

            using var connection = connectionFactory.Create();
            using var command = BuildCommand(sql, connection, entity);
            connection.Open();
            return Convert.ToInt32(command.ExecuteScalar());
        }

        public bool Modificar(Presupuesto entity)
        {
            const string sql = """
                UPDATE Presupuestos
                SET Nombre = @Nombre,
                    CostoTotal = @CostoTotal,
                    MontoTotal = @MontoTotal,
                    Descuento = @Descuento,
                    HorasDisenio = @HorasDisenio,
                    HorasTrabajo = @HorasTrabajo,
                    MargenGanancia = @MargenGanancia,
                    MargenMerma = @MargenMerma,
                    MargenMaquinaria = @MargenMaquinaria,
                    Recargo = @Recargo
                WHERE Id = @Id;
                """;

            using var connection = connectionFactory.Create();
            using var command = BuildCommand(sql, connection, entity);
            command.Parameters.AddWithValue("@Id", entity.Id);
            connection.Open();
            return command.ExecuteNonQuery() > 0;
        }

        public bool Eliminar(int id)
        {
            using var connection = connectionFactory.Create();
            using var command = new SqliteCommand("DELETE FROM Presupuestos WHERE Id = @Id;", connection);
            command.Parameters.AddWithValue("@Id", id);
            connection.Open();
            return command.ExecuteNonQuery() > 0;
        }

        public Presupuesto? ObtenerPorId(int id)
        {
            using var connection = connectionFactory.Create();
            using var command = new SqliteCommand("SELECT * FROM Presupuestos WHERE Id = @Id;", connection);
            command.Parameters.AddWithValue("@Id", id);
            connection.Open();
            using var reader = command.ExecuteReader();
            return reader.Read() ? PresupuestoMapper.FromReader(reader) : null;
        }

        public List<Presupuesto> ListarTodo()
        {
            var items = new List<Presupuesto>();
            using var connection = connectionFactory.Create();
            using var command = new SqliteCommand("SELECT * FROM Presupuestos ORDER BY Nombre;", connection);
            connection.Open();
            using var reader = command.ExecuteReader();
            while (reader.Read())
            {
                items.Add(PresupuestoMapper.FromReader(reader));
            }
            return items;
        }

        public int ObtenerUltimoId()
        {
            using var connection = connectionFactory.Create();
            using var command = new SqliteCommand("SELECT COALESCE(MAX(Id), 0) FROM Presupuestos;", connection);
            connection.Open();
            return Convert.ToInt32(command.ExecuteScalar());
        }

        private static SqliteCommand BuildCommand(string sql, SqliteConnection connection, Presupuesto entity)
        {
            var command = new SqliteCommand(sql, connection);
            command.Parameters.AddWithValue("@Nombre", entity.Nombre);
            command.Parameters.AddWithValue("@CostoTotal", entity.CostoTotal);
            command.Parameters.AddWithValue("@MontoTotal", entity.MontoTotal);
            command.Parameters.AddWithValue("@Descuento", entity.Descuento);
            command.Parameters.AddWithValue("@HorasDisenio", entity.HorasDiseño);
            command.Parameters.AddWithValue("@HorasTrabajo", entity.HorasTrabajo);
            command.Parameters.AddWithValue("@MargenGanancia", entity.MargenGanancia);
            command.Parameters.AddWithValue("@MargenMerma", entity.MargenMerma);
            command.Parameters.AddWithValue("@MargenMaquinaria", entity.MargenMaquinaria);
            command.Parameters.AddWithValue("@Recargo", entity.Recargo);
            return command;
        }
    }
}
