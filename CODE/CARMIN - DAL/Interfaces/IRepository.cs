namespace CARMIN___DAL.Interfaces
{
    public interface IRepository<T>
    {
        int Guardar(T entity);

        bool Modificar(T entity);

        bool Eliminar(int id);

        T? ObtenerPorId(int id);

        List<T> ListarTodo();

        int ObtenerUltimoId();
    }
}
