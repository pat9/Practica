using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_4
{
    class Persona
    {
        int edad, aNac;

        public void ObtenerDatos(int ed)
        {
            edad = ed;
        }

        public int CalcularAño()
        {
            aNac = DateTime.Now.Year - edad;
            return aNac;
        }
    }
}
