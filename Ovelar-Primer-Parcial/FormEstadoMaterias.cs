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
    public partial class FormEstadoMaterias : Form
    {

        
        
        public FormEstadoMaterias()
        {
            InitializeComponent();




            
            this.dgvMaterias.DataSource = Sistema.ListaCursantes;
            
            

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgvMaterias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void FormEstadoMaterias_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormModificarMateria form = new FormModificarMateria(Sistema.ListaCursantes.ElementAt(this.dgvMaterias.CurrentCell.RowIndex));
            form.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void dgvMaterias_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
