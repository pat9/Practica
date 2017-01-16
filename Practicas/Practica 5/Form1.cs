using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_5
{
    public partial class Form1 : Form
    {
        Obrero ObjObrero = new Obrero();
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Calcular_Click(object sender, EventArgs e)
        {
            double salAnt = Convert.ToDouble(txt_SalAnt.Text);
            ObjObrero.ObtenerDatos(salAnt);

            txt_Inc.Text = ObjObrero.CalcularIncremento().ToString();
            txt_SalAct.Text = ObjObrero.CalcularSalario().ToString();

        }
    }
}
