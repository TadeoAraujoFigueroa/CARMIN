using CARMIN___BE.Entities;
using CARMIN___BLL.Interfaces;
using CARMIN___DAL.Interfaces;
using CARMIN___DAL.Repositories;

namespace CARMIN___BLL.Services
{
    public class InsumoImpresoraBLL : IABM<InsumoImpresora>
    {
        private readonly IInsumoImpresoraRepository repository;

        public InsumoImpresoraBLL(IInsumoImpresoraRepository? repository = null)
        {
            this.repository = repository ?? new InsumoImpresoraRepository();
        }

        public bool Guardar(InsumoImpresora entity)
        {
            entity.Id = repository.Guardar(entity);
            return entity.Id > 0;
        }

        public bool Eliminar(InsumoImpresora entity) => repository.Eliminar(entity.Id);

        public bool Modificar(InsumoImpresora entity) => repository.Modificar(entity);

        public InsumoImpresora? ObtenerPorId(int id) => repository.ObtenerPorId(id);

        public List<InsumoImpresora> ListarTodo() => repository.ListarTodo();

        public int obtenerUltimoId() => repository.ObtenerUltimoId();
    }
}
