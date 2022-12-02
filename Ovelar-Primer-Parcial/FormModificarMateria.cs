using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ovelar_Primer_Parcial
{
    public partial class FormModificarMateria : Form
    {
        Cursante alumno;
        public FormModificarMateria(Cursante alumno)
        {
            InitializeComponent();
            this.alumno = alumno;

            this.label1.Text = $"El Alumno: {this.alumno.Nombre} {this.alumno.Apellido}";
            this.label2.Text = $"Cursa: {this.alumno.materia} En estado '{this.alumno.estado}'";
        }






        private void FormModificarMateria_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            /* if (this.alumno.estado == "Libre")
             {
                 this.alumno.estado = "Regular";
             }
             else
             {
                 this.alumno.estado = "Libre";
             }

             foreach (Alumno a in Sistema.ListaAlumnos)
             {
                 if (a.Dni == alumno.Dni)
                 {
                     a.estado = alumno.estado;
                     break;
                     // Modifico el estado de la materia al alumno en la lista Alumnos
                 }
             }*/

            UserDao.ModificarEstadoMateria(alumno.id,"Libre");
            Sistema.CargarCursantes();
            
            this.DialogResult = DialogResult.OK;
            MessageBox.Show("Cambio efectuado correcamente");




        }
    }
}
