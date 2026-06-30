using CARMIN___BE.Entities;
using CARMIN___MAPPER.Helpers;
using Microsoft.Data.Sqlite;

namespace CARMIN___MAPPER.Mappers
{
    public static class IngresoMapper
    {
        public static Ingreso FromReader(SqliteDataReader reader)
        {
            return new Ingreso
            {
                Id = SqlReaderHelper.GetInt32(reader, "Id"),
                Fecha = SqlReaderHelper.GetDateTime(reader, "Fecha"),
                Monto = SqlReaderHelper.GetDecimal(reader, "Monto")
            };
        }
    }
}
