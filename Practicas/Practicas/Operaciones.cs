using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicas
{
    class Operaciones
    {
        int num1, num2;
        int resSuma, resMult, resResta, resDivision, ResResiduo;

        public void ObtenerDatos(int a , int b)
        {
            num1 = a;
            num2 = b;
        }

        public int Suma()
        {
            return resSuma = num1 + num2;
        }

        public int Resta()
        {
            return resResta = num1 - num2;
        }

        public int Multiplicacion()
        {
            return resMult = num1 * num2;
        }

        public int Division()
        {
            return resDivision = num1 / num2;
        }

        public int Residuo()
        {
            return ResResiduo = num1 % num2;
        }

    }
}
