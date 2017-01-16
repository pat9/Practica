using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_2
{
    public partial class Form1 : Form
    {

        TrianguloRectangulo triangulo = new TrianguloRectangulo();

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Calcular_Click(object sender, EventArgs e)
        {
            double bas = Convert.ToDouble(txt_Base.Text);
            double altura = Convert.ToDouble(txt_Altura.Text);
            triangulo.ObtenerDatos(bas, altura);

            txt_Area.Text = triangulo.CalcularArea().ToString();
            txt_Perimetro.Text = triangulo.CalcularPerimetro().ToString();
        }
    }
}
