using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_5
{
    class Obrero
    {
        double salAnt, inc, salAct;

        public void ObtenerDatos(double SalAn)
        {
            salAnt = SalAn;
        }

        public double CalcularIncremento()
        {
            return inc = salAnt * .25;
        }

        public double CalcularSalario()
        {
            return salAct = salAnt + inc;
        }
    }
}
