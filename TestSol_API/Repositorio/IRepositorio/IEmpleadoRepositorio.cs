using TestSol_API.ModelsTestSol;

namespace TestSol_API.Repositorio.IRepositorio
{
    public interface IAreaRepositorio : IRepositorio<Area>
    {
        Task Create(Area entidad);
        Task<Area> Update(Area entidad);
    }
}
