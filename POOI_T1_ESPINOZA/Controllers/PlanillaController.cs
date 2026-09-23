using POOI_T1_ESPINOZA.Models;
using System.Collections.Generic;
using System.Web.Mvc;

namespace POOI_T1_ESPINOZA.Controllers
{
    public class PlanillaController : Controller
    {
       
        private static List<Empleado> Planilla = new List<Empleado>()
        {
            new Empleado
            {
                idEmpleado = "E001",
                nombreEmpleado = "Juan Pérez",
                categoriaEmpleado = "E1",
                nHijos = 2,
                tipoContrato = "Indefinido"
            },

            new Empleado
            {
                idEmpleado = "E002",
                nombreEmpleado = "María López",
                categoriaEmpleado = "E2",
                nHijos = 1,
                tipoContrato = "Contratado"
            },

            new Empleado
            {
                idEmpleado = "E003",
                nombreEmpleado = "Carlos García",
                categoriaEmpleado = "E3",
                nHijos = 3,
                tipoContrato = "Indefinido"
            },

            new Empleado
            {
                idEmpleado = "E004",
                nombreEmpleado = "Ana Torres",
                categoriaEmpleado = "OTRA",
                nHijos = 0,
                tipoContrato = "Contratado"
            }
        };
        
        public ActionResult RegistrarEmpleado()
        {
            return View();
        }
     
        [HttpPost]
        public ActionResult RegistrarEmpleado(Empleado empleado)
        {
            Planilla.Add(empleado);

            return RedirectToAction("Index");
        }

        public ActionResult Index()
        {
            return View(Planilla);
        }
    }
}