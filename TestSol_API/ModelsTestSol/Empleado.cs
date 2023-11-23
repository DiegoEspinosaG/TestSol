using System;
using System.Collections.Generic;

namespace TestSol_API.ModelsTestSol;

public partial class Empleado
{
    public string EmpleadoId { get; set; } = null!;

    public string? Nombre { get; set; }

    public string? ApellidoPaterno { get; set; }

    public string? ApellidoMaterno { get; set; }

    public string? AreaId { get; set; }

    public DateTime? FechaNacimiento { get; set; }

    public double Sueldo { get; set; }

    public string? CreadoPor { get; set; }

    public DateTime? FechaAlta { get; set; }

    public string? ModificadoPor { get; set; }

    public DateTime? FechaModificacion { get; set; }

    public virtual Area? Area { get; set; }
}
