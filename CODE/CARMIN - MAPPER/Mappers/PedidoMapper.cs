using CARMIN___BE.Entities;
using CARMIN___MAPPER.Helpers;
using Microsoft.Data.Sqlite;

namespace CARMIN___MAPPER.Mappers
{
    public static class PedidoMapper
    {
        public static Pedido FromReader(SqliteDataReader reader)
        {
            return new Pedido
            {
                Id = SqlReaderHelper.GetInt32(reader, "Id"),
                Nombre = SqlReaderHelper.GetString(reader, "Nombre"),
                IdCliente = SqlReaderHelper.GetInt32(reader, "IdCliente"),
                IdPresupuesto = SqlReaderHelper.GetInt32(reader, "IdPresupuesto"),
                Estado = SqlReaderHelper.GetString(reader, "Estado"),
                EstadoDePago = SqlReaderHelper.GetString(reader, "EstadoDePago"),
                FechaDeEntrega = SqlReaderHelper.GetDateTime(reader, "FechaDeEntrega"),
                Importe = SqlReaderHelper.GetDecimal(reader, "Importe"),
                TiempoTotalDeProduccion = SqlReaderHelper.GetDecimal(reader, "TiempoTotalDeProduccion")
            };
        }
    }
}
