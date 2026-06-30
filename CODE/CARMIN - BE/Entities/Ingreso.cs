using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CARMIN___BE.Entities
{
    public class Ingreso
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Monto { get; set; }
    }
}
