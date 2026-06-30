using CARMIN___BE.Entities;
using CARMIN___MAPPER.Helpers;
using Microsoft.Data.Sqlite;

namespace CARMIN___MAPPER.Mappers
{
    public static class ImpresoraMapper
    {
        public static Impresora FromReader(SqliteDataReader reader)
        {
            var tipoImpresora = SqlReaderHelper.GetString(reader, "TipoImpresora");

            Impresora impresora = tipoImpresora switch
            {
                "Rendimiento" => new ImpresoraPorRendimiento(),
                "Calidad" => new ImpresoraPorCalidad(),
                _ => throw new InvalidOperationException($"Tipo de impresora desconocido: {tipoImpresora}")
            };

            impresora.Id = SqlReaderHelper.GetInt32(reader, "Id");
            impresora.Modelo = SqlReaderHelper.GetString(reader, "Modelo");
            impresora.Marca = SqlReaderHelper.GetString(reader, "Marca");
            impresora.Nombre = SqlReaderHelper.GetString(reader, "Nombre");
            impresora.Tecnologia = SqlReaderHelper.GetString(reader, "Tecnologia");

            return impresora;
        }
    }
}
