using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_2
{
    class TrianguloRectangulo
    {
        double bas, altura, lado3;
        double area, perimetro;

        public void ObtenerDatos(double ba, double alt)
        {
            bas = ba;
            altura = alt;
        } 

        public double CalcularArea()
        {
            return area = (bas * altura)/2;
        }

        public double CalcularPerimetro()
        {
            lado3 = Math.Pow(bas, 2) + Math.Pow(altura, 2);
            perimetro = Math.Sqrt(lado3) + bas + altura;
            return perimetro;
        }
    }
}
