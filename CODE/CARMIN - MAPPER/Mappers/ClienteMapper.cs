using CARMIN___BE.Entities;
using CARMIN___MAPPER.Helpers;
using Microsoft.Data.Sqlite;

namespace CARMIN___MAPPER.Mappers
{
    public static class ClienteMapper
    {
        public static Cliente FromReader(SqliteDataReader reader)
        {
            return new Cliente
            {
                Id = SqlReaderHelper.GetInt32(reader, "Id"),
                Nombre = SqlReaderHelper.GetString(reader, "Nombre"),
                Telefono = SqlReaderHelper.GetNullableString(reader, "Telefono"),
                Direccion = SqlReaderHelper.GetNullableString(reader, "Direccion")
            };
        }
    }
}
