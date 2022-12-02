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
    public partial class FormCuentaProfesor : Form
    {
        User usuarioLogueado;
        public FormCuentaProfesor(User usuarioLogueado )
        {
            InitializeComponent();
            this.usuarioLogueado = usuarioLogueado;

            this.label2.Text = $"Nombre: {this.usuarioLogueado.Nombre}";
            this.label3.Text = $"Apellido: {this.usuarioLogueado.Apellido}";
            this.label4.Text = $"Usuario: {this.usuarioLogueado.Usuario}";
            this.label5.Text = $"Dni: {usuarioLogueado.GetHashCode()}";
        }

        private void FormCuentaProfesor_Load(object sender, EventArgs e)
        {

        }
    }
}
