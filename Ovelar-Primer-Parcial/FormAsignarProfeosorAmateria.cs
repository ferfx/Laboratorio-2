using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace Ovelar_Primer_Parcial
{
    public partial class FormAsignarProfeosorAmateria : Form
    {
        User profesor;
        public FormAsignarProfeosorAmateria(User profesor)
        {
            InitializeComponent();
            this.profesor = profesor;

            this.label1.Text = $"Profesor: {this.profesor.Nombre}, ¿A que materia asignar?";
        }

        private void FormAsignarProfeosorAmateria_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*if(Sistema.ListaMaterias[0].listaProfesores[0].Usuario == profesor.Usuario)
            {
                MessageBox.Show("Este profesor ya dicta esta Materia");
            }else
            {
                Sistema.ListaMaterias[0].listaProfesores.Add(profesor);
                this.DialogResult = DialogResult.OK;
                MessageBox.Show("Profesor asignado correcamente");
            }*/
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*if (Sistema.ListaMaterias[1].listaProfesores[0].Usuario == profesor.Usuario)
            {
                MessageBox.Show("Este profesor ya dicta esta Materia");
            }
            else
            {
                Sistema.ListaMaterias[1].listaProfesores.Add(profesor);
                this.DialogResult = DialogResult.OK;
                MessageBox.Show("Profesor asignado correcamente");
            }*/
        }
    }
}
