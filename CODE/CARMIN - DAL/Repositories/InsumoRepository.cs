using CARMIN___BE.Entities;
using CARMIN___DAL.Interfaces;
using CARMIN___DAL.Sqlite;
using CARMIN___MAPPER.Mappers;
using Microsoft.Data.Sqlite;

namespace CARMIN___DAL.Repositories
{
    public class InsumoRepository : IRepository<Insumo>
    {
        private readonly SqliteConnectionFactory connectionFactory;

        public InsumoRepository(SqliteConnectionFactory? connectionFactory = null)
        {
            this.connectionFactory = connectionFactory ?? new SqliteConnectionFactory();
        }

        public int Guardar(Insumo entity)
        {
            const string sql = """
                INSERT INTO Insumos
                (Nombre, Cantidad, UnidadMedida, CostoInsumo, Stock, TipoDeCalculo, TipoInsumo, Contenido, UnidadContenido, Precio, Rendimiento, EsColor)
                VALUES
                (@Nombre, @Cantidad, @UnidadMedida, @CostoInsumo, @Stock, @TipoDeCalculo, @TipoInsumo, @Contenido, @UnidadContenido, @Precio, @Rendimiento, @EsColor);
                SELECT last_insert_rowid();
                """;

            using var connection = connectionFactory.Create();
            using var command = BuildCommand(sql, connection, entity, "General");
            connection.Open();
            return Convert.ToInt32(command.ExecuteScalar());
        }

        public bool Modificar(Insumo entity)
        {
            const string sql = """
                UPDATE Insumos
                SET Nombre = @Nombre,
                    Cantidad = @Cantidad,
                    UnidadMedida = @UnidadMedida,
                    CostoInsumo = @CostoInsumo,
                    Stock = @Stock,
                    TipoDeCalculo = @TipoDeCalculo,
                    TipoInsumo = @TipoInsumo,
                    Contenido = @Contenido,
                    UnidadContenido = @UnidadContenido,
                    Precio = @Precio,
                    Rendimiento = @Rendimiento,
                    EsColor = @EsColor
                WHERE Id = @Id;
                """;

            using var connection = connectionFactory.Create();
            using var command = BuildCommand(sql, connection, entity, "General");
            command.Parameters.AddWithValue("@Id", entity.Id);
            connection.Open();
            return command.ExecuteNonQuery() > 0;
        }

        public bool Eliminar(int id)
        {
            using var connection = connectionFactory.Create();
            using var command = new SqliteCommand("DELETE FROM Insumos WHERE Id = @Id;", connection);
            command.Parameters.AddWithValue("@Id", id);
            connection.Open();
            return command.ExecuteNonQuery() > 0;
        }

        public Insumo? ObtenerPorId(int id)
        {
            using var connection = connectionFactory.Create();
            using var command = new SqliteCommand("SELECT * FROM Insumos WHERE Id = @Id;", connection);
            command.Parameters.AddWithValue("@Id", id);
            connection.Open();
            using var reader = command.ExecuteReader();
            return reader.Read() ? (InsumoMapper.FromReader(reader) as Insumo) : null;
        }

        public List<Insumo> ListarTodo()
        {
            var items = new List<Insumo>();
            using var connection = connectionFactory.Create();
            using var command = new SqliteCommand("SELECT * FROM Insumos WHERE TipoInsumo = 'General' ORDER BY Nombre;", connection);
            connection.Open();
            using var reader = command.ExecuteReader();
            while (reader.Read())
            {
                if (InsumoMapper.FromReader(reader) is Insumo item)
                {
                    items.Add(item);
                }
            }
            return items;
        }

        public int ObtenerUltimoId()
        {
            using var connection = connectionFactory.Create();
            using var command = new SqliteCommand("SELECT COALESCE(MAX(Id), 0) FROM Insumos;", connection);
            connection.Open();
            return Convert.ToInt32(command.ExecuteScalar());
        }

        internal static SqliteCommand BuildCommand(string sql, SqliteConnection connection, InsumoPadre entity, string tipoInsumo)
        {
            var command = new SqliteCommand(sql, connection);
            command.Parameters.AddWithValue("@Nombre", entity.Nombre);
            command.Parameters.AddWithValue("@TipoInsumo", tipoInsumo);

            if (entity is InsumoImpresora insumoImpresora)
            {
                command.Parameters.AddWithValue("@Contenido", insumoImpresora.Contenido);
                command.Parameters.AddWithValue("@UnidadContenido", insumoImpresora.UnidadContenido);
                command.Parameters.AddWithValue("@Precio", insumoImpresora.Precio);
                command.Parameters.AddWithValue("@Rendimiento", insumoImpresora.Rendimiento);
                command.Parameters.AddWithValue("@EsColor", insumoImpresora.EsColor);
                command.Parameters.AddWithValue("@Cantidad", DBNull.Value);
                command.Parameters.AddWithValue("@UnidadMedida", DBNull.Value);
                command.Parameters.AddWithValue("@CostoInsumo", DBNull.Value);
                command.Parameters.AddWithValue("@Stock", DBNull.Value);
                command.Parameters.AddWithValue("@TipoDeCalculo", DBNull.Value);
            }
            else if (entity is Insumo insumoGeneral)
            {
                command.Parameters.AddWithValue("@Cantidad", insumoGeneral.Cantidad);
                command.Parameters.AddWithValue("@UnidadMedida", insumoGeneral.UnidadMedida);
                command.Parameters.AddWithValue("@CostoInsumo", insumoGeneral.CostoInsumo);
                command.Parameters.AddWithValue("@Stock", insumoGeneral.Stock);
                command.Parameters.AddWithValue("@TipoDeCalculo", insumoGeneral.TipoDeCalculo);
                command.Parameters.AddWithValue("@Contenido", DBNull.Value);
                command.Parameters.AddWithValue("@UnidadContenido", DBNull.Value);
                command.Parameters.AddWithValue("@Precio", DBNull.Value);
                command.Parameters.AddWithValue("@Rendimiento", DBNull.Value);
                command.Parameters.AddWithValue("@EsColor", DBNull.Value);
            }

            return command;
        }
    }
}
