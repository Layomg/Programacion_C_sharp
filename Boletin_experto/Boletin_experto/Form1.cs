using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Boletin_experto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void boton_borrar_Click(object sender, EventArgs e)
        {
            namePlayer_1.Clear();
            namePlayer_2.Clear();
            namePlayer_3.Clear();
        }

        private void boton_añadir_Click(object sender, EventArgs e)
        {
            if (!namePlayer_1.Text.Equals(namePlayer_2.Text) && (!namePlayer_1.Text.Equals(namePlayer_3.Text)) && (!label_nameplayer_2.Text.Equals(namePlayer_3.Text)))
            {
                if (namePlayer_1.Text != "admin" && namePlayer_2.Text != "admin" && namePlayer_3.Text != "admin")
                {
                    MessageBox.Show("Correcto");
                }
                else
                {
                    MessageBox.Show("Incorrecto");
                }
            }
            else
            {
                MessageBox.Show("Incorrecto");
            }
        }
    }
}
