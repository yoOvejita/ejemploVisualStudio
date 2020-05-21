using introduccion.ActionFilters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace introduccion.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        [MiFiltroHistorial]
        public ActionResult Index()
        {
            return RedirectToAction("Buscar", "Empleado");
        }
        [OutputCache(Duration = 20)]
        [ActionName("Tiempo")]
        public string GetHora() {
            return ObtenerTiempo().ToString("T");
        }
        [NonAction]
        public DateTime ObtenerTiempo() {//Este es un método (que no retorna una vista)
            return DateTime.Now;
        }
        public ActionResult MiView() {
            return View();
        }
    }
}