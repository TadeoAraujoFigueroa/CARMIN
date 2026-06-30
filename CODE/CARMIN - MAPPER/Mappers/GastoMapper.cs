using CARMIN___BE.Entities;
using CARMIN___MAPPER.Helpers;
using Microsoft.Data.Sqlite;

namespace CARMIN___MAPPER.Mappers
{
    public static class GastoMapper
    {
        public static Gasto FromReader(SqliteDataReader reader)
        {
            return new Gasto
            {
                Id = SqlReaderHelper.GetInt32(reader, "Id"),
                Fecha = SqlReaderHelper.GetDateTime(reader, "Fecha"),
                Monto = SqlReaderHelper.GetDecimal(reader, "Monto"),
                Descripcion = SqlReaderHelper.GetNullableString(reader, "Descripcion")
            };
        }
    }
}
