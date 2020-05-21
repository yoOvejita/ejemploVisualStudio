using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace introduccion.Models
{
    public class Empleado
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public DateTime fechaInicio { get; set; }
        public int Edad { get; set; }
    }
}