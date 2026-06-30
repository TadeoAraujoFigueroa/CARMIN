using CARMIN___BE.Entities;
using CARMIN___BLL.Interfaces;
using CARMIN___DAL.Interfaces;
using CARMIN___DAL.Repositories;

namespace CARMIN___BLL.Services
{
    public class InsumoBLL : IABM<Insumo>
    {
        private readonly IRepository<Insumo> repository;

        public InsumoBLL(IRepository<Insumo>? repository = null)
        {
            this.repository = repository ?? new InsumoRepository();
        }

        public bool Guardar(Insumo entity)
        {
            entity.Id = repository.Guardar(entity);
            return entity.Id > 0;
        }

        public bool Eliminar(Insumo entity) => repository.Eliminar(entity.Id);

        public bool Modificar(Insumo entity) => repository.Modificar(entity);

        public Insumo? ObtenerPorId(int id) => repository.ObtenerPorId(id);

        public List<Insumo> ListarTodo() => repository.ListarTodo();

        public int obtenerUltimoId() => repository.ObtenerUltimoId();   
    }
}
