using TestSol_API.ModelsTestSol;
using TestSol_API.Repositorio.IRepositorio;

namespace TestSol_API.Repositorio
{
    public class AreaRepositorio : Repositorio<Area>, IAreaRepositorio
    {
        private readonly TestSolContext _db;

        public AreaRepositorio(TestSolContext db) : base(db)
        {
            _db = db;
        }

        public async Task Create(Area entidad)
        {
            await _db.Areas.AddAsync(entidad);
            await _db.SaveChangesAsync();
        }

        public async Task<Area> Update(Area entidad)
        {
            _db.Areas.Update(entidad);
            await _db.SaveChangesAsync();
            return entidad;
        }
    }
}
