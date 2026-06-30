using CARMIN___BE.Entities;
using CARMIN___MAPPER.Helpers;
using Microsoft.Data.Sqlite;

namespace CARMIN___MAPPER.Mappers
{
    public static class PresupuestoMapper
    {
        public static Presupuesto FromReader(SqliteDataReader reader)
        {
            return new Presupuesto
            {
                Id = SqlReaderHelper.GetInt32(reader, "Id"),
                Nombre = SqlReaderHelper.GetString(reader, "Nombre"),
                CostoTotal = SqlReaderHelper.GetDecimal(reader, "CostoTotal"),
                MontoTotal = SqlReaderHelper.GetDecimal(reader, "MontoTotal"),
                Descuento = SqlReaderHelper.GetDecimal(reader, "Descuento"),
                HorasDiseño = SqlReaderHelper.GetDecimal(reader, "HorasDisenio"),
                HorasTrabajo = SqlReaderHelper.GetDecimal(reader, "HorasTrabajo"),
                MargenGanancia = SqlReaderHelper.GetDecimal(reader, "MargenGanancia"),
                MargenMerma = SqlReaderHelper.GetDecimal(reader, "MargenMerma"),
                MargenMaquinaria = SqlReaderHelper.GetDecimal(reader, "MargenMaquinaria"),
                Recargo = SqlReaderHelper.GetDecimal(reader, "Recargo")
            };
        }
    }
}
