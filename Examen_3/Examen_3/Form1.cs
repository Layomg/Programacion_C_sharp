using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void botonComprobar_Click(object sender, EventArgs e)
        {
            if (usuario.Text.Equals(password.Text))
            {
                MessageBox.Show("El nombre de usuario y el password deben ser distintos");
            }
        }
    }
}
