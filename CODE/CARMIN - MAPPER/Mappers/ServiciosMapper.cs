using CARMIN___BE.Entities;
using CARMIN___MAPPER.Helpers;
using Microsoft.Data.Sqlite;

namespace CARMIN___MAPPER.Mappers
{
    public static class ServiciosMapper
    {
        public static Servicios FromReader(SqliteDataReader reader)
        {
            return new Servicios
            {
                Id = SqlReaderHelper.GetInt32(reader, "Id"),
                Nombre = SqlReaderHelper.GetString(reader, "Nombre"),
                ImporteMensual = SqlReaderHelper.GetDecimal(reader, "ImporteMensual")
            };
        }
    }
}
