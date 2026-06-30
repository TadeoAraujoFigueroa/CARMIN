using CARMIN___BE.Entities;
using CARMIN___BLL.Interfaces;
using CARMIN___DAL.Interfaces;
using CARMIN___DAL.Repositories;

namespace CARMIN___BLL.Services
{
    public class PresupuestoBLL : IABM<Presupuesto>
    {
        private readonly IRepository<Presupuesto> repository;

        public PresupuestoBLL(IRepository<Presupuesto>? repository = null)
        {
            this.repository = repository ?? new PresupuestoRepository();
        }

        public bool Guardar(Presupuesto entity)
        {
            //El 
            entity.Id = repository.Guardar(entity);
            return entity.Id > 0;
        }

        public bool Eliminar(Presupuesto entity) => repository.Eliminar(entity.Id);

        public bool Modificar(Presupuesto entity) => repository.Modificar(entity);

        public Presupuesto? ObtenerPorId(int id) => repository.ObtenerPorId(id);

        public List<Presupuesto> ListarTodo() => repository.ListarTodo();

        public int obtenerUltimoId() => repository.ObtenerUltimoId();
    }
}
