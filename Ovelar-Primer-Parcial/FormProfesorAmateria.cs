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
    public partial class FormProfesorAmateria : Form
    {
        public FormProfesorAmateria()
        {
            InitializeComponent();

            this.dataGridView1.DataSource = Sistema.ListaProfesores;
        }

        private void FormProfesorAmateria_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormAsignarProfeosorAmateria form = new FormAsignarProfeosorAmateria(Sistema.ListaProfesores.ElementAt(this.dataGridView1.CurrentCell.RowIndex));
            form.ShowDialog();
            this.dataGridView1.DataSource = null;
            this.dataGridView1.DataSource = Sistema.ListaProfesores;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
