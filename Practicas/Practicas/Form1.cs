using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practicas
{
    public partial class Form1 : Form
    {
        Operaciones ObjOp = new Operaciones();

        public Form1()
        {
            InitializeComponent();
        }

        private void SoloNumeros(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }

        private void btn_Calcular_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(txt_Num1.Text);
            int b = Convert.ToInt32(txt_Num2.Text);
            ObjOp.ObtenerDatos(a, b);

            txt_Suma.Text = ObjOp.Suma().ToString();
            txt_Resta.Text = ObjOp.Resta().ToString();
            txt_Mult.Text = ObjOp.Multiplicacion().ToString();
            txt_Div.Text = ObjOp.Division().ToString();
            txt_Residuo.Text = ObjOp.Residuo().ToString();
        }

        private void txt_Num1_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(sender, e);
        }

        private void txt_Num2_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(sender, e);
        }
    }
}
