using CARMIN___BE.Entities;
using CARMIN___BLL.Interfaces;
using CARMIN___DAL.Interfaces;
using CARMIN___DAL.Repositories;

namespace CARMIN___BLL.Services
{
    public class ImpresoraBLL : IABM<Impresora>
    {
        private readonly IRepository<Impresora> repository;

        public ImpresoraBLL(IRepository<Impresora>? repository = null)
        {
            this.repository = repository ?? new ImpresoraRepository();
        }

        public bool Guardar(Impresora entity)
        {
            entity.Id = repository.Guardar(entity);
            return entity.Id > 0;
        }

        public bool Eliminar(Impresora entity) => repository.Eliminar(entity.Id);

        public bool Modificar(Impresora entity) => repository.Modificar(entity);

        public Impresora? ObtenerPorId(int id) => repository.ObtenerPorId(id);

        public List<Impresora> ListarTodo() => repository.ListarTodo();

        public int ObtenerUltimoId() => repository.ObtenerUltimoId();
    }
}
