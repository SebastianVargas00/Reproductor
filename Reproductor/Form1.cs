using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reproductor
{
    public partial class Form1 : Form
    {
        private string ruta = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK) {
                ruta = openFileDialog1.FileName;
                label_name.Text = ruta;
            }
        }

        private void reproducirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Displayer.URL = ruta;
            Displayer.Ctlcontrols.play();
        }

        private void pararToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Displayer.Ctlcontrols.stop();
        }

        private void pausaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Displayer.Ctlcontrols.pause();
        }


        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ayudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Para mas informacion acceder a la siguiente url: https://es.wikipedia.org/wiki/Reproductor_multimedia_digital#:~:text=Un%20reproductor%20multimedia%20digital%20es,de%20video%2C%20audio%20e%20im%C3%A1genes.&text=Los%20reproductores%20multimedia%20digitales%20reproducen,y%20no%20obligatoriamente%20el%20formato%20*.");
        }
    }
}
