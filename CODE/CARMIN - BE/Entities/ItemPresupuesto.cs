using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CARMIN___BE.Entities
{
    public class ItemPresupuesto
    {
        public ItemPresupuesto()
        {
                
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public decimal Cantidad { get; set; }
        public decimal PrecioUnitario { get; set; }
        public decimal Descuento { get; set; }
        public decimal Recargo { get; set; }
        public decimal Costo { get; set; }
    }
}
