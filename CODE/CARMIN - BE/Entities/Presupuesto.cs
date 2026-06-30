using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CARMIN___BE.Entities
{
    public class Presupuesto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public decimal CostoTotal { get; set; }
        public decimal MontoTotal { get; set; }
        public decimal Descuento { get; set; }
        public decimal HorasDiseño { get; set; }
        public decimal HorasTrabajo { get; set; }
        public decimal MargenGanancia { get; set; }
        public decimal MargenMerma { get; set; }
        public decimal MargenMaquinaria { get; set; }
        public decimal Recargo { get; set; }
    }
}
