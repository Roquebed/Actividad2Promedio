using Actividad2Promedio.Models;
using Microsoft.AspNetCore.Mvc;

namespace Actividad2Promedio.Controllers
{
    public class HomeController : Controller
    {
        public void ObtenerPromedio(Promedio calificaciones)
        {
            calificaciones.Promedioo = (calificaciones.Calificacion1 + calificaciones.Calificacion2 + calificaciones.Calificacion3) / 3;
            if (calificaciones.Promedioo >= 70)
            {
                calificaciones.Estado = "Aprobado";
            }
            else calificaciones.Estado = "Reprobado";
        }
        public IActionResult Index(Promedio pro)
        {

            ObtenerPromedio(pro);
            return View(pro);
        }
    }
}
