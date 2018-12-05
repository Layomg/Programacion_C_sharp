using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void botonCalcular_Click(object sender, EventArgs e)
        {
            if (primer_operando.Text == "" || segundo_operando.Text == "" || primer_operando.Text == "0" || segundo_operando.Text == "0")
            {
                resultado.Text = "0";
            } else
            {
                resultado.Text = (double.Parse(primer_operando.Text) / double.Parse(segundo_operando.Text)).ToString();
            }
        }
    }
}
