using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void botonSorpresa_Click(object sender, EventArgs e)
        {
            if (float.Parse(numsorpresa.Text) >= 1 && float.Parse(numsorpresa.Text) <= 5) {
                if (float.Parse(numsorpresa.Text) % 2 == 0)
                {
                    resultados.Text = "El número " + numsorpresa.Text + " es par";
                } else
                {
                    resultados.Text = "El número " + numsorpresa.Text + " es impar";
                }
            } else
            {

            }
        }
    }
}
