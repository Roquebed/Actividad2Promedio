using Microsoft.AspNetCore.Mvc;

namespace Actividad2Promedio.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
