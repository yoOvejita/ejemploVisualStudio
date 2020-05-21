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
        public string GetHora() {
            return DateTime.Now.ToString("T");
        }
    }
}