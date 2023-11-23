using TestSol_API.ModelsTestSol;

namespace TestSol_API.Repositorio.IRepositorio
{
    public interface IEmpleadoRepositorio : IRepositorio<Empleado>
    {
        Task Create(Empleado entidad);
        Task<Empleado> Update(Empleado entidad);
    }
}
