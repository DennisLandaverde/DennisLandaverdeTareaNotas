using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaEstudiante.Modelo;
namespace SistemaEstudiante
{
    public partial class LOGUIN : Form
    {
        public LOGUIN()
        {
            InitializeComponent();
        }

        private void linklblSalir_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();
        }

        private void btnInicioSesion_Click(object sender, EventArgs e)
        {
            using (EstudiantesEntities db = new EstudiantesEntities())
            {
                var Lista = from Estudiante in db.Estudiante
                            where Estudiante.Usuario == txtUsuario.Text
                            && Estudiante.Contraseña == txtContraseña.Text
                            select Estudiante;

                if (Lista.Count() > 0)
                {
                    MessageBox.Show("Haz iniciado sesion ");
                    Vista.Menu menu = new Vista.Menu();
                    menu.Show();
                    this.Hide();
                }



                else
                {
                    MessageBox.Show("El Usuario no existe en el sistema");
                }

            }
        }

        private void LOGUIN_Load(object sender, EventArgs e)
        {

        }
    }
}
