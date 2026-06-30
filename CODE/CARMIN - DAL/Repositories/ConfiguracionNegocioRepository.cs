using CARMIN___BE.Entities;
using CARMIN___DAL.Interfaces;
using CARMIN___DAL.Sqlite;
using CARMIN___MAPPER.Mappers;
using Microsoft.Data.Sqlite;

namespace CARMIN___DAL.Repositories
{
    public class ConfiguracionNegocioRepository : IRepository<ConfiguracionNegocio>
    {
        private readonly SqliteConnectionFactory connectionFactory;

        public ConfiguracionNegocioRepository(SqliteConnectionFactory? connectionFactory = null)
        {
            this.connectionFactory = connectionFactory ?? new SqliteConnectionFactory();
        }

        public int Guardar(ConfiguracionNegocio entity)
        {
            const string sql = """
                INSERT INTO ConfiguracionesNegocio
                (HorasProductivasMensuales, MargenGanancia, PorcentajeMaquinaria, PorcentajeMerma, HoraManoDeObra)
                VALUES (@HorasProductivasMensuales, @MargenGanancia, @PorcentajeMaquinaria, @PorcentajeMerma, @HoraManoDeObra);
                SELECT last_insert_rowid();
                """;

            using var connection = connectionFactory.Create();
            using var command = new SqliteCommand(sql, connection);
            AddParameters(command, entity);
            connection.Open();
            return Convert.ToInt32(command.ExecuteScalar());
        }

        public bool Modificar(ConfiguracionNegocio entity)
        {
            const string sql = """
                UPDATE ConfiguracionesNegocio
                SET HorasProductivasMensuales = @HorasProductivasMensuales,
                    MargenGanancia = @MargenGanancia,
                    PorcentajeMaquinaria = @PorcentajeMaquinaria,
                    PorcentajeMerma = @PorcentajeMerma,
                    HoraManoDeObra = @HoraManoDeObra
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
            using var command = new SqliteCommand("DELETE FROM ConfiguracionesNegocio WHERE Id = @Id;", connection);
            command.Parameters.AddWithValue("@Id", id);
            connection.Open();
            return command.ExecuteNonQuery() > 0;
        }

        public ConfiguracionNegocio? ObtenerPorId(int id)
        {
            using var connection = connectionFactory.Create();
            using var command = new SqliteCommand("SELECT * FROM ConfiguracionesNegocio WHERE Id = @Id;", connection);
            command.Parameters.AddWithValue("@Id", id);
            connection.Open();
            using var reader = command.ExecuteReader();
            return reader.Read() ? ConfiguracionNegocioMapper.FromReader(reader) : null;
        }

        public List<ConfiguracionNegocio> ListarTodo()
        {
            var items = new List<ConfiguracionNegocio>();
            using var connection = connectionFactory.Create();
            using var command = new SqliteCommand("SELECT * FROM ConfiguracionesNegocio ORDER BY Id;", connection);
            connection.Open();
            using var reader = command.ExecuteReader();
            while (reader.Read())
            {
                items.Add(ConfiguracionNegocioMapper.FromReader(reader));
            }

            return items;
        }

        public int ObtenerUltimoId()
        {
            using var connection = connectionFactory.Create();
            using var command = new SqliteCommand("SELECT COALESCE(MAX(Id), 0) FROM ConfiguracionesNegocio;", connection);
            connection.Open();
            return Convert.ToInt32(command.ExecuteScalar());
        }

        private static void AddParameters(SqliteCommand command, ConfiguracionNegocio entity)
        {
            command.Parameters.AddWithValue("@HorasProductivasMensuales", entity.HorasProductivasMensuales);
            command.Parameters.AddWithValue("@MargenGanancia", entity.MargenGanancia);
            command.Parameters.AddWithValue("@PorcentajeMaquinaria", entity.PorcentajeMaquinaria);
            command.Parameters.AddWithValue("@PorcentajeMerma", entity.PorcentajeMerma);
            command.Parameters.AddWithValue("@HoraManoDeObra", entity.HoraManoDeObra);
        }
    }
}
