using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CARMIN___BE.Entities
{
    public class DetalleImpresion
    {
        public int Id { get; set; }
        public decimal CostoUnitario { get; set; }
        public int Cantidad { get; set; }

    }
}
