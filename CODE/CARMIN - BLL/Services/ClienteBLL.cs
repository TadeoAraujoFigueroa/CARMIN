using CARMIN___BE.Entities;
using CARMIN___BLL.Interfaces;
using CARMIN___DAL.Interfaces;
using CARMIN___DAL.Repositories;

namespace CARMIN___BLL.Services
{
    public class ClienteBLL : IABM<Cliente>
    {
        private readonly IRepository<Cliente> clienteRepository;

        public ClienteBLL(IRepository<Cliente>? clienteRepository = null)
        {
            this.clienteRepository = clienteRepository ?? new ClienteRepository();
        }

        public bool Guardar(Cliente entity)
        {
            Validar(entity);
            entity.Id = clienteRepository.Guardar(entity);
            return entity.Id > 0;
        }

        public bool Eliminar(Cliente entity)
        {
            return clienteRepository.Eliminar(entity.Id);
        }

        public bool Modificar(Cliente entity)
        {
            Validar(entity);
            return clienteRepository.Modificar(entity);
        }

        public Cliente? ObtenerPorId(int id)
        {
            return clienteRepository.ObtenerPorId(id);
        }

        public List<Cliente> ListarTodo()
        {
            return clienteRepository.ListarTodo();
        }

        private static void Validar(Cliente cliente)
        {
            if (string.IsNullOrWhiteSpace(cliente.Nombre))
            {
                throw new ArgumentException("El nombre del cliente es obligatorio.");
            }
        }
    }
}
