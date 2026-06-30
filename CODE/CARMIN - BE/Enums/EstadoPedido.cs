using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CARMIN___BE.Enums
{
    public enum EstadoPedidoProduccion
    {
        ENCARGADO,
        PROCESANDO,
        DEMORADO,
        FINALIZADO
    }

    public enum EstadoPedidoPago
    {
        PENDIENTE,
        SEÑADO,
        ABONADO
    }
}
