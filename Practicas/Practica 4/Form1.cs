using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_4
{
    public partial class Form1 : Form
    {
        Persona ObjPersona = new Persona();

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Calcular_Click(object sender, EventArgs e)
        {
            int edad = Convert.ToInt32(txt_Edad.Text);
            ObjPersona.ObtenerDatos(edad);

            txt_ANac.Text = ObjPersona.CalcularAño().ToString();
        }
    }
}
