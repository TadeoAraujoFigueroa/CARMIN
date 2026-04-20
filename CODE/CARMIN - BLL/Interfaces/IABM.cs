using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CARMIN___BLL.Interfaces
{
    public interface IABM<T>
    {
        public bool Guardar(T entity);

        public bool Eliminar(T entity);

        public bool Modificar(T entity);
    }
}
