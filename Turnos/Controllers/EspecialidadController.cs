using Microsoft.AspNetCore.Mvc;

namespace Turnos.Controllers
{
    public class EspecialidadController : Controller
    {
        public EspecialidadController()
        {

        }

        public IActionResult Index()  //El IActionResult retorna los datos a la vista Index en este caso para que muestren en el frontal
        {
            return View();
        }
    }
}