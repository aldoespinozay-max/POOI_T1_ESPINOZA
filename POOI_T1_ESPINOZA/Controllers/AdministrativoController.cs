using POOI_T1_ESPINOZA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace POOI_T1_ESPINOZA.Controllers
{
    public class AdministrativoController : Controller
    {
        public ActionResult RegistrarAdministrativo()
        {
            return View();
        }

        [HttpPost]
        public ActionResult RegistrarAdministrativo(Administrativo administrativo)
        {
            ViewBag.SueldoBasico = administrativo.SueldoBasico();
            ViewBag.Escolaridad = administrativo.Escolaridad();
            ViewBag.Incentivo = administrativo.Incentivo();
            ViewBag.Bonificacion = administrativo.Bonificacion();
            ViewBag.MontoAPagar = administrativo.MontoAPagar();

            return View(administrativo);
        }
    }
}