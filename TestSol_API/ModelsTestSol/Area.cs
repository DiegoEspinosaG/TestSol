using System;
using System.Collections.Generic;

namespace TestSol_API.ModelsTestSol;

public partial class Area
{
    public string AreaId { get; set; } = null!;

    public string? Area1 { get; set; }

    public virtual ICollection<Empleado> Empleados { get; set; } = new List<Empleado>();
}
