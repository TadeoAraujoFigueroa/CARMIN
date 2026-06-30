using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CARMIN___BE.Entities
{
    public abstract class InsumoPadre
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
    }
    public class InsumoImpresora : InsumoPadre
    {
        public int Contenido { get; set; }
        public string UnidadContenido { get; set; }
        public decimal Precio { get; set; }
        public int Rendimiento { get; set; }
        public bool EsColor { get; set; }
    }
}
