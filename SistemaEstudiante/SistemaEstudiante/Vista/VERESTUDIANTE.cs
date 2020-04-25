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
    public partial class VERESTUDIANTE : Form
    {
        Modelo.Estudiante user = new Modelo.Estudiante();
        public VERESTUDIANTE()
        {
            InitializeComponent();
        }
        void LimpiarDatos()
        {
            txtNombreEstu.Text = "";
            txtContraEstu.Text = "";
            txtNombreU.Text = "";

        }
        void CargarDatos()
        {
            using (EstudiantesEntities db = new EstudiantesEntities())
            {
                var Jointablas = from Estudiante in db.Estudiante
                                                                                              
                                 select new
                                 {

                                     Nombre = Estudiante.NombreEstudiante, 
                                     Usuario = Estudiante.Usuario,
                                     Contraseña = Estudiante.Contraseña

                                 };


                dtvUsuarios.DataSource = Jointablas.ToList();



            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Vista.Menu menu = new Vista.Menu();
            menu.Show();
            this.Hide();
        }

        private void VERESTUDIANTE_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            using (EstudiantesEntities db = new EstudiantesEntities())
            {
                String Id = dtvUsuarios.CurrentRow.Cells[0].Value.ToString();

                int Idc = int.Parse(Id);

                user = db.Estudiante.Where(VerificarId => VerificarId.IdEstudiante == Idc).First();
                user.NombreEstudiante = txtNombreEstu.Text;
                user.Usuario = txtNombreU.Text;
                user.Contraseña = txtContraEstu.Text;

                db.Entry(user).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
            CargarDatos();
            LimpiarDatos();
        }

        private void dtvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            String Nombre = dtvUsuarios.CurrentRow.Cells[0].Value.ToString();
            String Usuario = dtvUsuarios.CurrentRow.Cells[1].Value.ToString();
            String Contraseña = dtvUsuarios.CurrentRow.Cells[2].Value.ToString();
            txtNombreEstu.Text = Nombre;
            txtNombreU.Text = Usuario;
            txtContraEstu.Text = Contraseña;
        }
    }
}
