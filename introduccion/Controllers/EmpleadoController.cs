using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace introduccion.Controllers
{
    public class EmpleadoController : Controller
    {
        // GET: Empleado
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Buscar(string nombre) {
            return Content("El texto es: "+nombre);
        }
        [HttpGet]
        public ActionResult Buscar() {//Uso de los action verbs
            return Content("Este Action ahora es el llamado cuando se lo referencia por GET.");
        }
    }
}