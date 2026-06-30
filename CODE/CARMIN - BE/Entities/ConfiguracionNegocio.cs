using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CARMIN___BE.Entities
{
    public class ConfiguracionNegocio
    {
        public int Id  { get; set; }
        public int HorasProductivasMensuales { get; set; }
        public int MargenGanancia { get; set; }
        public int PorcentajeMaquinaria { get; set; }
        public int PorcentajeMerma { get; set; }
        public decimal HoraManoDeObra { get; set; }
    }
}
