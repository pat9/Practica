using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_3
{
    public partial class Form1 : Form
    {
        Conversion Conv = new Conversion();
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Calcular_Click(object sender, EventArgs e)
        {
            double CM = Convert.ToDouble(txt_CM.Text);
            Conv.ObtenerDatos(CM);

            txt_Pul.Text = Conv.Covertir().ToString();
        }
    }
}
