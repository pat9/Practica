using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_3
{
    class Conversion
    {
        double medidaCM, medidaPul;

        public void ObtenerDatos(double mCm)
        {
            medidaCM = mCm;
        }

        public double Covertir()
        {
            medidaPul = medidaCM / 2.54;
            return medidaPul;
        }
    }
}
