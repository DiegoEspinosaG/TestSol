using System.Linq.Expressions;

namespace TestSol_API.Repositorio.IRepositorio
{
    public interface IRepositorio<T> where T : class
    {
        Task<List<T>> GetAll(Expression<Func<T, bool>>? filtro = null);
        Task<T> GetById(Expression<Func<T, bool>> filtro = null, bool tracked = true);
        Task Remove(T entidad);
        Task SaveChanges();
    }
}
