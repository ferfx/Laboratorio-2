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
    public partial class FormAltaAlumno : Form
    {
        public FormAltaAlumno()
        {
            InitializeComponent();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            List<User> lista = new List<User>();
            int id;
            int cont = 0;

            string usuario = this.textBox1.Text;
            string contraseña = this.textBox2.Text;
            string nombre = this.textBox3.Text;
            string apellido = this.textBox4.Text;
            bool x = int.TryParse(this.textBox5.Text, out int dni);
            bool z = int.TryParse(this.textBox6.Text, out int edad);

            lista = Sistema.ListaAlumnos; ;

            foreach (User aux in lista)
            {
                cont++;
            }
            id = lista[cont - 1].id + 1;  //  NUEVO ID PARA ALUMNO EN LAS LISTA DINAMICAS


            if (usuario != "" & contraseña != "" & nombre != "" & apellido != "" & x != false & z != false)
            {

                this.DialogResult = DialogResult.OK;
                Sistema.ListaAlumnos.Add(new User(id,usuario, contraseña, nombre, apellido, dni, edad));
                UserDao.AddAlumno(usuario, contraseña, nombre, apellido, dni, edad);
                MessageBox.Show("Nuevo Alumno Agregado");

            }
            else
            {
                MessageBox.Show("ERROR, CAMPOS VACIOS O INVALIDOS");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void FormAltaAlumno_Load(object sender, EventArgs e)
        {

        }
    }
}
