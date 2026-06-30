using CARMIN___BE.Entities;
using CARMIN___BLL.Interfaces;
using CARMIN___DAL.Interfaces;
using CARMIN___DAL.Repositories;

namespace CARMIN___BLL.Services
{
    public class ServiciosBLL : IABM<Servicios>
    {
        private readonly IRepository<Servicios> repository;

        public ServiciosBLL(IRepository<Servicios>? repository = null)
        {
            this.repository = repository ?? new ServiciosRepository();
        }

        public bool Guardar(Servicios entity)
        {
            entity.Id = repository.Guardar(entity);
            return entity.Id > 0;
        }

        public bool Eliminar(Servicios entity) => repository.Eliminar(entity.Id);

        public bool Modificar(Servicios entity) => repository.Modificar(entity);

        public Servicios? ObtenerPorId(int id) => repository.ObtenerPorId(id);

        public List<Servicios> ListarTodo() => repository.ListarTodo();

        public int ObtenerUltimoId() => repository.ObtenerUltimoId();
    }
}
