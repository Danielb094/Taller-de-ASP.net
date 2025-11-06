using Microsoft.AspNetCore.Mvc;
using Taller_sena_1 .Models;

namespace Taller_sena_1.Controllers
{
    public class PersonaController : Controller
    {
        public IActionResult Index()
        {
            List<Persona> Lista = new List<Persona>();

            Persona Per1= new Persona();
            Per1.Id = 1;
            Per1.Nombre = "Ricardo";
            Per1.PrimerApellido = "Castelblanco";
            Per1.SegundoApellido = "Sepulvedad";
            Lista.Add(Per1);

            Persona Per2= new Persona();
            Per2.Id = 2;
            Per2.Nombre = "Daniel";
            Per2.PrimerApellido = "Gamboa";
            Per2.SegundoApellido = "Beltran";
            Lista.Add(Per2);

            Persona Per3= new Persona();
            Per3.Id = 3;
            Per3.Nombre = "Juanito";
            Per3.PrimerApellido = "Perez";
            Per3.SegundoApellido = "Sandoval";
            Lista.Add(Per3);


            return View(Lista);
        }
    }
}
