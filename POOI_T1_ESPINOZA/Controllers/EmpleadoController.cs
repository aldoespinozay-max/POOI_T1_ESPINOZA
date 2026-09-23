using POOI_T1_ESPINOZA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace POOI_T1_ESPINOZA.Controllers
{
    public class EmpleadoController : Controller
    {

        public ActionResult RegistrarEmpleado()
        {
            return View();
        }

        [HttpPost]
        public ActionResult RegistrarEmpleado(Empleado empleado)
        {
            ViewBag.SueldoBasico = empleado.SueldoBasico();
            ViewBag.Escolaridad = empleado.Escolaridad();
            ViewBag.Bonificacion = empleado.Bonificacion();
            ViewBag.MontoAPagar = empleado.MontoAPagar();

            return View(empleado);
        }
    }
}