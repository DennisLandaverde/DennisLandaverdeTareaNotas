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
    public partial class INGRESARNOTA : Form
    {
        Modelo.Materia user = new Modelo.Materia();
        public INGRESARNOTA()
        {
            InitializeComponent();
        }
        void LimpiarDatos()
        {
            txtIdEstudiante.Text = "";
            txtIdMateria.Text = "";
            
            txtNota.Text = "";

        }
        void CargarDatos()
        {
            using (EstudiantesEntities db = new EstudiantesEntities())
            {
                
                
                    var Jointablas = from Estudiante in db.Estudiante
                                     from Materia in db.Materia
                                     from Nota in db.Notas
                                     where Nota.IdEstudiante == Estudiante.IdEstudiante && Nota.IdMateria == Materia.IdMateria
                                     select new
                                     {

                                         Estudiante = Estudiante.NombreEstudiante,
                                         Materia = Materia.NombreMateria,
                                         Nota = Nota.Nota




                                     };

                foreach (var Datos in Jointablas)
                {
                    dtvNotas.Rows.Add(Datos.Estudiante, Datos.Materia, Datos.Nota, Datos);
                }


                
            }
        }

        private void txtIdMateria_TextChanged(object sender, EventArgs e)
        {

        }

        private void INGRESARNOTA_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Vista.Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }

        private void dtvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
            String IdM = dtvNotas.CurrentRow.Cells[1].Value.ToString();
            String IdE = dtvNotas.CurrentRow.Cells[2].Value.ToString();
            String Nota = dtvNotas.CurrentRow.Cells[3].Value.ToString();
            
            txtIdMateria.Text = IdM;
            txtIdEstudiante.Text = IdE;
            txtNota.Text = Nota;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Notas notas = new Notas();
            using (EstudiantesEntities db = new EstudiantesEntities())
            {
                String Id = dtvNotas.CurrentRow.Cells[0].Value.ToString();
                int Idc = int.Parse(Id);
                notas = db.Notas.Where(VerificarId => VerificarId.IdNotas == Idc).First();
                notas.IdEstudiante = Convert.ToInt32(txtIdEstudiante.Text);
                notas.IdMateria = Convert.ToInt32(txtIdMateria.Text);
                notas.Nota = Convert.ToInt32(txtNota.Text);
                db.Entry(notas).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();


            }
            LimpiarDatos();
            CargarDatos();
        }
    }
}
