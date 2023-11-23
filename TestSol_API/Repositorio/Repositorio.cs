using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using TestSol_API.ModelsTestSol;
using TestSol_API.Repositorio.IRepositorio;

namespace TestSol_API.Repositorio
{
    public class Repositorio<T> : IRepositorio<T> where T : class
    {
        private readonly TestSolContext _db;
        internal DbSet<T> dbSet;

        public Repositorio(TestSolContext db)
        {
            _db = db;
            dbSet = _db.Set<T>();
        }

        public async Task<List<T>> GetAll(Expression<Func<T, bool>>? filtro = null)
        {
            IQueryable<T> query = dbSet;

            if (filtro != null) query = query.Where(filtro);

            return await query.ToListAsync();
        }

        public async Task<T> GetById(Expression<Func<T, bool>> filtro = null, bool tracked = true)
        {
            IQueryable<T> query = dbSet;

            if (!tracked) query = query.AsNoTracking();
            if (filtro != null) query = query.Where(filtro);

            return await query.FirstOrDefaultAsync();
        }

        public async Task Remove(T entidad)
        {
            dbSet.Remove(entidad);
            await SaveChanges();
        }

        public async Task SaveChanges()
        {
            await _db.SaveChangesAsync();
        }
    }
}
