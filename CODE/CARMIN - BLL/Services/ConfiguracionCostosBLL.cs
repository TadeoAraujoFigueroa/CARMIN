using CARMIN___BE.Entities;
using CARMIN___BLL.Interfaces;
using CARMIN___DAL.Interfaces;
using CARMIN___DAL.Repositories;

namespace CARMIN___BLL.Services
{
    public class ConfiguracionCostosBLL : IABM<ConfiguracionNegocio>
    {
        private readonly IRepository<ConfiguracionNegocio> repository;

        public ConfiguracionCostosBLL(IRepository<ConfiguracionNegocio>? repository = null)
        {
            this.repository = repository ?? new ConfiguracionNegocioRepository();
        }

        public bool Guardar(ConfiguracionNegocio entity)
        {
            entity.Id = repository.Guardar(entity);
            return entity.Id > 0;
        }

        public bool Eliminar(ConfiguracionNegocio entity) => repository.Eliminar(entity.Id);

        public bool Modificar(ConfiguracionNegocio entity) => repository.Modificar(entity);

        public ConfiguracionNegocio? ObtenerPorId(int id) => repository.ObtenerPorId(id);

        public List<ConfiguracionNegocio> ListarTodo() => repository.ListarTodo();
    }
}
