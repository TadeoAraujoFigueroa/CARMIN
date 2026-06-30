using CARMIN___BE.Entities;
using CARMIN___MAPPER.Helpers;
using Microsoft.Data.Sqlite;

namespace CARMIN___MAPPER.Mappers
{
    public static class PerfilImpresionMapper
    {
        public static PerfilImpresion FromReader(SqliteDataReader reader)
        {
            return new PerfilImpresion
            {
                Id = SqlReaderHelper.GetInt32(reader, "Id"),
                Nombre = SqlReaderHelper.GetString(reader, "Nombre"),
                Precio = SqlReaderHelper.GetDecimal(reader, "Precio"),
                FactorMultiplicador = SqlReaderHelper.GetDecimal(reader, "FactorMultiplicador"),
                EsColor = SqlReaderHelper.GetBoolean(reader, "EsColor")
            };
        }
    }
}
