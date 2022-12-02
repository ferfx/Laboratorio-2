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
    public partial class FormAltaMateria : Form
    {
        public FormAltaMateria()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string a = this.textBox1.Text;
            string b = this.textBox2.Text;
            string c = this.textBox3.Text;

            //int cont = Sistema.ListaMaterias.Count();
            //int id = Sistema.ListaMaterias[cont].id +1;

            if (a != "" & b != "" & c != "")
            {
                this.DialogResult = DialogResult.OK;
                //Sistema.ListaMaterias.Add(new Materia(id,a, b, c)); // CAMBIAR
                MateriaDao.AddMateria(a, b, c);
                Sistema.CargarMaterias();
                MessageBox.Show("Nueva Materia Agregada");
            }
            else
            {
                MessageBox.Show("ERROR, CAMPOS VACIOS O INVALIDOS");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void FormAltaMateria_Load(object sender, EventArgs e)
        {

        }
    }
}
