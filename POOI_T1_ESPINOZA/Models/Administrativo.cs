using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace POOI_T1_ESPINOZA.Models
{
    public class Administrativo : Empleado
    {
        public int anioIngreso { get; set; }
        public bool postGrado { get; set; }

    
        public double Incentivo()
        {
            if (postGrado == true)
            {
                return 500;
            }
            else
            {
                return 0;
            }
        }

        public override double Bonificacion()
        {
            int aniosServicio = DateTime.Now.Year - anioIngreso;

            if (aniosServicio < 5)
            {
                return 200;
            }
            else if (aniosServicio <= 10)
            {
                return 450;
            }
            else
            {
                return 300;
            }
        }

        public new double MontoAPagar()
        {
            return SueldoBasico()
                 + Bonificacion()
                 + Escolaridad()
                 + Incentivo();
        }
    }
}