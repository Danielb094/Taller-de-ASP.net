using System;
using System.Collections.Generic;

namespace Taller_sena_2.Models;

public partial class Cargo
{
    public int CarCod { get; set; }

    public string CarDes { get; set; } = null!;

    public virtual ICollection<Usuario> Usuarios { get; set; } = new List<Usuario>();
}
