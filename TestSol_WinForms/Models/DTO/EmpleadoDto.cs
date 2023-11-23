using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSol_WinForms.Models.DTO
{
    internal class EmpleadoDto
    {
        public string EmpleadoId { get; set; }

        public string Nombre { get; set; }

        public string ApellidoPaterno { get; set; }

        public string ApellidoMaterno { get; set; }

        public string AreaId { get; set; }

        public DateTime? FechaNacimiento { get; set; }

        public double Sueldo { get; set; }
    }
}
