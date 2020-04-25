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
    public partial class MATERIA : Form
    {
        Modelo.Materia user = new Modelo.Materia();
        public MATERIA()
        {
            InitializeComponent();
        }
        void CargarDatos()
        {
            using (EstudiantesEntities db = new EstudiantesEntities())
            {
                var Jointablas = from Materia in db.Materia

                                 select new
                                 {
                                     Id = Materia.IdMateria,
                                     Materia = Materia.NombreMateria,
                                     

                                 };


                dtvUsuarios.DataSource = Jointablas.ToList();

            }
        }
            void LimpiarDatos()
        {
            txtNombreMateria.Text = "";
            txtIdMateria.Text = "";
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Vista.Menu menu = new Vista.Menu();
            menu.Show();
            this.Hide();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            using (EstudiantesEntities db = new EstudiantesEntities())
            {
                var Lista = user.NombreMateria = txtNombreMateria.Text;
                
                
                db.Materia.Add(user);
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
            LimpiarDatos();
            CargarDatos();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            using (EstudiantesEntities db = new EstudiantesEntities())
            {
                String Id = dtvUsuarios.CurrentRow.Cells[1].Value.ToString();

                int Idc = int.Parse(Id);

                user = db.Materia.Where(VerificarId => VerificarId.IdMateria == Idc).First();
                user.NombreMateria = txtNombreMateria.Text;

                db.Entry(user).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
            CargarDatos();
            LimpiarDatos();
        }

        private void MATERIA_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void dtvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            String Id = dtvUsuarios.CurrentRow.Cells[0].Value.ToString();
            String Materia = dtvUsuarios.CurrentRow.Cells[1].Value.ToString();
            txtNombreMateria.Text = Materia;
            txtIdMateria.Text = Id;
            
        }
    }
    
}
