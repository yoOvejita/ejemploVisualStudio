using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace introduccion.ActionFilters
{
    public class MiFiltroHistorial : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            Historial("OnActionExecuting", filterContext.RouteData);
        }
        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            Historial("OnActionExecuted", filterContext.RouteData);
        }
        public override void OnResultExecuting(ResultExecutingContext filterContext)
        {
            Historial("OnResultExecuting", filterContext.RouteData);
        }
        public override void OnResultExecuted(ResultExecutedContext filterContext)
        {
            Historial("OnResultExecuted", filterContext.RouteData);
        }
        public void Historial(string nombreMetodo, RouteData routeData) {
            var nombreController = routeData.Values["controller"];
            var nombreAction = routeData.Values["action"];
            var mensaje = String.Format("METODO: {2} - Controlador: {0}, Acción: {1}.",nombreController,nombreAction,nombreMetodo);
            Debug.WriteLine(mensaje,"Historial de filter");
        }
    }
}