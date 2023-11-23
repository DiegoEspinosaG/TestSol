using TestSol_API.ModelsTestSol;
using TestSol_API.Repositorio.IRepositorio;

namespace TestSol_API.Repositorio
{
    public class EmpleadoRepositorio : Repositorio<Empleado>, IEmpleadoRepositorio
    {
        private readonly TestSolContext _db;

        public EmpleadoRepositorio(TestSolContext db) : base(db)
        {
            _db = db;
        }

        public async Task Create(Empleado entidad)
        {
            entidad.CreadoPor = "Sistemas";
            entidad.FechaAlta = DateTime.Now;
            await _db.Empleados.AddAsync(entidad);
            await _db.SaveChangesAsync();
        }

        public async Task<Empleado> Update(Empleado entidad)
        {
            entidad.ModificadoPor = "Sistemas";
            entidad.FechaModificacion = DateTime.Now;
            _db.Empleados.Update(entidad);
            await _db.SaveChangesAsync();
            return entidad;
        }
    }
}
