using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace POOI_T1_ESPINOZA.Models
{
    public class Empleado
    {
        public string idEmpleado { get; set; }
        public string nombreEmpleado { get; set; }
        public string categoriaEmpleado { get; set; }
        public int nHijos { get; set; }
        public string tipoContrato { get; set; }


        public double SueldoBasico()
        {
            if (categoriaEmpleado == "E1")
            {
                return 5500;
            }
            else if (categoriaEmpleado == "E2")
            {
                return 2500;
            }
            else if (categoriaEmpleado == "E3")
            {
                return 2200;
            }
            else
            {
                return 1700;
            }
        }

        public double Escolaridad()
        {
            return nHijos * 108;
        }

        public virtual double Bonificacion()
        {
            if (tipoContrato == "Indefinido")
            {
                return SueldoBasico() * 0.15;
            }
            else if (tipoContrato == "Contratado")
            {
                return SueldoBasico() * 0.10;
            }

            return 0;
        }

        public double MontoAPagar()
        {
            return SueldoBasico() + Escolaridad() + Bonificacion();
        }
    }
}