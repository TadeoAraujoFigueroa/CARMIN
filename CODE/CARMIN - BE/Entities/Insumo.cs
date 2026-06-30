using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CARMIN___BE.Entities
{
    public class Insumo : InsumoPadre
    {

        public decimal Cantidad { get; set; }
        public string UnidadMedida { get; set; }
        public decimal CostoInsumo { get; set; }
        public decimal Stock { get; set; }
        public decimal PrecioUnitario { get { if(TipoDeCalculo == "PorUnidad" && Cantidad != 0) return CostoInsumo / Cantidad; else return 0; } }
        public string TipoDeCalculo { get; set; }
    }
}
