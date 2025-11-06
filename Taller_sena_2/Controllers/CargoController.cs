using Taller_sena_2.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Taller_sena_2.Controllers
{
    public class CargoController : Controller
    {
        private readonly BdEscuela1Context _context;

        public CargoController(BdEscuela1Context context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View( _context.Usuarios.ToList());

        }

        public async Task<IActionResult> Cargos()
        {
            return View(_context.Cargos.ToList());
        }
    }
}
