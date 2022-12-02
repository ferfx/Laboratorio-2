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
    public partial class FormCuentaAdmin : Form
    {
        User usuarioLogueado;
        public FormCuentaAdmin(User usuarioLogueado)
        {
            InitializeComponent();
            this.usuarioLogueado = usuarioLogueado;


            this.label2.Text = $"Nombre: {this.usuarioLogueado.Nombre}";
            this.label3.Text = $"Apellido: {this.usuarioLogueado.Apellido}";
            this.label4.Text = $"Usuario: {this.usuarioLogueado.Usuario}";
            this.label5.Text = $"Dni: {usuarioLogueado.GetHashCode()}";
        }

        private void FormCuentaAdmin_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
