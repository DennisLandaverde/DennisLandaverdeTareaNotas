using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaEstudiante.Vista
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void registrarEstudianteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Vista.REGISTRAREST ver = new Vista.REGISTRAREST();
            ver.Show();
            this.Hide();

        }

        private void verEstudiantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Vista.VERESTUDIANTE ver = new Vista.VERESTUDIANTE();
            ver.Show();
            this.Hide();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblNombre_Click(object sender, EventArgs e)
        {
            
        }

        private void ingresarMateriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MATERIA materia = new MATERIA();
            materia.Show();
            this.Hide();
        }

        private void ingresarNotaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Vista.INGRESARNOTA ing = new INGRESARNOTA();
            ing.Show();
            this.Hide();
        }
    }
}
