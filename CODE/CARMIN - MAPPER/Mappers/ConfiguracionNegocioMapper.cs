using CARMIN___BE.Entities;
using CARMIN___MAPPER.Helpers;
using Microsoft.Data.Sqlite;

namespace CARMIN___MAPPER.Mappers
{
    public static class ConfiguracionNegocioMapper
    {
        public static ConfiguracionNegocio FromReader(SqliteDataReader reader)
        {
            return new ConfiguracionNegocio
            {
                Id = SqlReaderHelper.GetInt32(reader, "Id"),
                HorasProductivasMensuales = SqlReaderHelper.GetInt32(reader, "HorasProductivasMensuales"),
                MargenGanancia = SqlReaderHelper.GetInt32(reader, "MargenGanancia"),
                PorcentajeMaquinaria = SqlReaderHelper.GetInt32(reader, "PorcentajeMaquinaria"),
                PorcentajeMerma = SqlReaderHelper.GetInt32(reader, "PorcentajeMerma"),
                HoraManoDeObra = SqlReaderHelper.GetDecimal(reader, "HoraManoDeObra")
            };
        }
    }
}
