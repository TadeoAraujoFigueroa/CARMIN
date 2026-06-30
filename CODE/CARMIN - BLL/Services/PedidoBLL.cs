using CARMIN___BE.Entities;
using CARMIN___BLL.Interfaces;
using CARMIN___DAL.Interfaces;
using CARMIN___DAL.Repositories;

namespace CARMIN___BLL.Services
{
    public class PedidoBLL : IABM<Pedido>
    {
        private readonly IRepository<Pedido> repository;

        public PedidoBLL(IRepository<Pedido>? repository = null)
        {
            this.repository = repository ?? new PedidoRepository();
        }

        public bool Guardar(Pedido entity)
        {
            entity.Id = repository.Guardar(entity);
            return entity.Id > 0;
        }

        public bool Eliminar(Pedido entity) => repository.Eliminar(entity.Id);

        public bool Modificar(Pedido entity) => repository.Modificar(entity);

        public Pedido? ObtenerPorId(int id) => repository.ObtenerPorId(id);

        public List<Pedido> ListarTodo() => repository.ListarTodo();

        public int ObtenerUltimoId() => repository.ObtenerUltimoId();
    }
}
