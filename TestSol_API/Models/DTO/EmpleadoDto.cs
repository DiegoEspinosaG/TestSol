using TestSol_API.ModelsTestSol;

namespace TestSol_API.Models.DTO
{
    public class EmpleadoDto
    {
        public string EmpleadoId { get; set; } = null!;

        public string? Nombre { get; set; }

        public string? ApellidoPaterno { get; set; }

        public string? ApellidoMaterno { get; set; }

        public string? AreaId { get; set; }

        public DateTime? FechaNacimiento { get; set; }

        public double Sueldo { get; set; }
    }
}
