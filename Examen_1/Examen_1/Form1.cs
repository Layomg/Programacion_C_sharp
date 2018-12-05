using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void botonAñadir_Click(object sender, EventArgs e)
        {
            if (tipoAlimento.Text == "fruta")
            {
                listaFruta.Items.Add(cantidadFruta.Text);
            }
            if (tipoAlimento.Text == "bollería")
            {
                listaBolleria.Items.Add(cantidadFruta.Text);
            }
            if (tipoAlimento.Text == "lácteos")
            {
                listaLacteos.Items.Add(cantidadFruta.Text);
            }
        }

        private void botonResultados_Click(object sender, EventArgs e)
        {
            int totalFruta=0, totalBolleria=0, totalLacteos=0;
            for (int i = 0; i < listaFruta.Items.Count; i++)
            {
                listaFruta.SetSelected(i, true);
                totalFruta = totalFruta + int.Parse(listaFruta.SelectedItem.ToString());
                listaFruta.SetSelected(i, false);
            }
            for (int i = 0; i < listaBolleria.Items.Count; i++)
            {
                listaBolleria.SetSelected(i, true);
                totalBolleria = totalBolleria + int.Parse(listaBolleria.SelectedItem.ToString());
                listaBolleria.SetSelected(i, false);
            }
            for (int i = 0; i < listaLacteos.Items.Count; i++)
            {
                listaLacteos.SetSelected(i, true);
                totalLacteos = totalLacteos + int.Parse(listaLacteos.SelectedItem.ToString());
                listaLacteos.SetSelected(i, false);
            }
            resumen.Text = "De todos los ciudadanos consultados, se puede resumir que se consume: " + totalFruta + " piezas de fruta al día, " + totalBolleria + " unidades de bollería al día y " + totalLacteos + " unidades de lácteos";
        }
    }
}
