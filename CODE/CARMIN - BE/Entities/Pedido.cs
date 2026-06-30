using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CARMIN___BE.Entities
{
    public class Pedido
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int IdCliente { get; set; }
        public int IdPresupuesto { get; set; }
        public string Estado { get; set; }
        public string EstadoDePago { get; set; }
        public DateTime FechaDeEntrega { get; set; }
        public decimal Importe { get; set; }
        public decimal TiempoTotalDeProduccion { get; set; }
    }
}
