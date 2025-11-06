using System;
using System.Collections.Generic;

namespace Taller_sena_2.Models;

public partial class Usuario
{
    public int UsuCod { get; set; }

    public string UsuNom { get; set; } = null!;

    public int CarCod { get; set; }

    public virtual Cargo CarCodNavigation { get; set; } = null!;
}
