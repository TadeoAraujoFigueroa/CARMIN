using CARMIN___BE.Entities;
using CARMIN___MAPPER.Helpers;
using Microsoft.Data.Sqlite;

namespace CARMIN___MAPPER.Mappers
{
    public static class InsumoMapper
    {
        public static InsumoPadre FromReader(SqliteDataReader reader)
        {
            var tipoInsumo = SqlReaderHelper.GetString(reader, "TipoInsumo");

            if (tipoInsumo == "Impresora")
            {
                return new InsumoImpresora
                {
                    Id = SqlReaderHelper.GetInt32(reader, "Id"),
                    Nombre = SqlReaderHelper.GetString(reader, "Nombre"),
                    Contenido = SqlReaderHelper.GetNullableInt32(reader, "Contenido") ?? 0,
                    UnidadContenido = SqlReaderHelper.GetNullableString(reader, "UnidadContenido") ?? string.Empty,
                    Precio = SqlReaderHelper.GetNullableDecimal(reader, "Precio") ?? 0m,
                    Rendimiento = SqlReaderHelper.GetNullableInt32(reader, "Rendimiento") ?? 0,
                    EsColor = SqlReaderHelper.GetNullableBoolean(reader, "EsColor") ?? false
                };
            }

            return new Insumo
            {
                Id = SqlReaderHelper.GetInt32(reader, "Id"),
                Nombre = SqlReaderHelper.GetString(reader, "Nombre"),
                Cantidad = SqlReaderHelper.GetDecimal(reader, "Cantidad"),
                UnidadMedida = SqlReaderHelper.GetString(reader, "UnidadMedida"),
                CostoInsumo = SqlReaderHelper.GetDecimal(reader, "CostoInsumo"),
                Stock = SqlReaderHelper.GetDecimal(reader, "Stock"),
                TipoDeCalculo = SqlReaderHelper.GetString(reader, "TipoDeCalculo")
            };
        }
    }
}
