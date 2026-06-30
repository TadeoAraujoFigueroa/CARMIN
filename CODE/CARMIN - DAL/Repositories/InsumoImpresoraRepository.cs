using CARMIN___BE.Entities;
using CARMIN___DAL.Interfaces;
using CARMIN___DAL.Sqlite;
using CARMIN___MAPPER.Mappers;
using Microsoft.Data.Sqlite;

namespace CARMIN___DAL.Repositories
{
    public class InsumoImpresoraRepository : IInsumoImpresoraRepository
    {
        private readonly SqliteConnectionFactory connectionFactory;

        public InsumoImpresoraRepository(SqliteConnectionFactory? connectionFactory = null)
        {
            this.connectionFactory = connectionFactory ?? new SqliteConnectionFactory();
        }

        public int Guardar(InsumoImpresora entity)
        {
            const string sql = """
                INSERT INTO Insumos
                (Nombre, Cantidad, UnidadMedida, CostoInsumo, Stock, TipoDeCalculo, TipoInsumo, Contenido, UnidadContenido, Precio, Rendimiento, EsColor)
                VALUES
                (@Nombre, @Cantidad, @UnidadMedida, @CostoInsumo, @Stock, @TipoDeCalculo, @TipoInsumo, @Contenido, @UnidadContenido, @Precio, @Rendimiento, @EsColor);
                SELECT last_insert_rowid();
                """;

            using var connection = connectionFactory.Create();
            using var command = InsumoRepository.BuildCommand(sql, connection, entity, "Impresora");
            connection.Open();
            return Convert.ToInt32(command.ExecuteScalar());
        }

        public bool Modificar(InsumoImpresora entity)
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
            using var command = InsumoRepository.BuildCommand(sql, connection, entity, "Impresora");
            command.Parameters.AddWithValue("@Id", entity.Id);
            connection.Open();
            return command.ExecuteNonQuery() > 0;
        }

        public bool Eliminar(int id)
        {
            using var connection = connectionFactory.Create();
            using var command = new SqliteCommand("DELETE FROM Insumos WHERE Id = @Id AND TipoInsumo = 'Impresora';", connection);
            command.Parameters.AddWithValue("@Id", id);
            connection.Open();
            return command.ExecuteNonQuery() > 0;
        }

        public InsumoImpresora? ObtenerPorId(int id)
        {
            using var connection = connectionFactory.Create();
            using var command = new SqliteCommand("SELECT * FROM Insumos WHERE Id = @Id AND TipoInsumo = 'Impresora';", connection);
            command.Parameters.AddWithValue("@Id", id);
            connection.Open();
            using var reader = command.ExecuteReader();
            return reader.Read() ? (InsumoMapper.FromReader(reader) as InsumoImpresora) : null;
        }

        public List<InsumoImpresora> ListarTodo()
        {
            var items = new List<InsumoImpresora>();
            using var connection = connectionFactory.Create();
            using var command = new SqliteCommand("SELECT * FROM Insumos WHERE TipoInsumo = 'Impresora' ORDER BY Nombre;", connection);
            connection.Open();
            using var reader = command.ExecuteReader();
            while (reader.Read())
            {
                if (InsumoMapper.FromReader(reader) is InsumoImpresora item)
                {
                    items.Add(item);
                }
            }
            return items;
        }

        public int ObtenerUltimoId()
        {
            using var connection = connectionFactory.Create();
            using var command = new SqliteCommand("SELECT COALESCE(MAX(Id), 0) FROM Insumos WHERE TipoInsumo = 'Impresora';", connection);
            connection.Open();
            return Convert.ToInt32(command.ExecuteScalar());
        }
    }
}
