using CARMIN___BE.Entities;
using CARMIN___DAL.Interfaces;
using CARMIN___DAL.Repositories;

namespace CARMIN___BLL.Services
{
    public class FinanzasBLL
    {
        private readonly IRepository<Gasto> gastoRepository;
        private readonly IRepository<Ingreso> ingresoRepository;

        public FinanzasBLL(IRepository<Gasto>? gastoRepository = null, IRepository<Ingreso>? ingresoRepository = null)
        {
            this.gastoRepository = gastoRepository ?? new GastoRepository();
            this.ingresoRepository = ingresoRepository ?? new IngresoRepository();
        }

        public bool GuardarGasto(Gasto gasto)
        {
            gasto.Id = gastoRepository.Guardar(gasto);
            return gasto.Id > 0;
        }

        public bool ModificarGasto(Gasto gasto) => gastoRepository.Modificar(gasto);

        public bool EliminarGasto(int id) => gastoRepository.Eliminar(id);

        public Gasto? ObtenerGastoPorId(int id) => gastoRepository.ObtenerPorId(id);

        public List<Gasto> ListarGastos() => gastoRepository.ListarTodo();

        public bool GuardarIngreso(Ingreso ingreso)
        {
            ingreso.Id = ingresoRepository.Guardar(ingreso);
            return ingreso.Id > 0;
        }

        public bool ModificarIngreso(Ingreso ingreso) => ingresoRepository.Modificar(ingreso);

        public bool EliminarIngreso(int id) => ingresoRepository.Eliminar(id);

        public Ingreso? ObtenerIngresoPorId(int id) => ingresoRepository.ObtenerPorId(id);

        public List<Ingreso> ListarIngresos() => ingresoRepository.ListarTodo();
    }
}
