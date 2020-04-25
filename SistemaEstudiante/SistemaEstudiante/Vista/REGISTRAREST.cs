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

namespace SistemaEstudiante.Vista
{
   
    public partial class REGISTRAREST : Form
    {
        Modelo.Estudiante user = new Modelo.Estudiante();
        public REGISTRAREST()
        {
            InitializeComponent();
        }
        void LimpiarDatos()
        {
            txtNombreEstu.Text = "";
            txtContraEstu.Text = "";
            txtNombreU.Text = "";
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Vista.Menu menu = new Vista.Menu();
            menu.Show();
            this.Hide();
        }

        private void REGISTRAREST_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            using (EstudiantesEntities db = new EstudiantesEntities ())
            {
                var Lista = user.NombreEstudiante = txtNombreEstu.Text;
                    user.Contraseña = txtContraEstu.Text;
                    user.Usuario = txtNombreU.Text;
                    db.Estudiante.Add(user);
                    db.SaveChanges();

                if (Lista.Count() > 0)
                {
                    MessageBox.Show("GUARDADO");

                }
                else
                {
                    MessageBox.Show("ERROR");
                }
        
                
                
            }
            
            
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarDatos();
        }
    }
}
