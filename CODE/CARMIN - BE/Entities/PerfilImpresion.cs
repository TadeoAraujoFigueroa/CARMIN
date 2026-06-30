using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CARMIN___BE.Entities
{
    public class PerfilImpresion
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public decimal Precio { get; set; } = 0m;
        public decimal FactorMultiplicador { get; set; } = 1m;
        public bool EsColor { get; set; }
    }
}
