using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CARMIN___BE.Entities
{
    public class Insumo
    {
        public Insumo()
        {
            
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public decimal Cantidad { get; set; }
        public string UnidadMedida { get; set; }
        public decimal CostoInsumo { get; set; }
        public decimal Stock { get; set; }
        public decimal PrecioUnitario { get { return CostoInsumo / Cantidad; } }
    }
}
