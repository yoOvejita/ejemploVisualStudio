using introduccion.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace introduccion.Controllers
{
    public class Empleado2Controller : Controller
    {
        // GET: Empleado2
        public ActionResult Index()
        {
            var empleados = from e in GetListaEmpleados()
                            orderby e.ID
                            select e;
            return View(empleados);
        }

        // GET: Empleado2/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Empleado2/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Empleado2/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Empleado2/Edit/5
        public ActionResult Edit(int id)
        {
            List<Empleado> listaOt = GetListaEmpleados();
            var empleado = listaOt.Single(m => m.ID == id);
            return View(empleado);
        }

        // POST: Empleado2/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Empleado2/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Empleado2/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        [NonAction]
        public List<Empleado> GetListaEmpleados() {
            return new List<Empleado>{
                new Empleado{ ID=4, Nombre="Pepe",fechaInicio = DateTime.Parse(DateTime.Today.ToString()),Edad = 20 },
                new Empleado{ ID=2, Nombre="Ana",fechaInicio = DateTime.Parse(DateTime.Today.ToString()),Edad= 40 },
                new Empleado{ ID=9, Nombre="Richard",fechaInicio = DateTime.Parse(DateTime.Today.ToString()),Edad = 34 }
            };
        }
    }
}
