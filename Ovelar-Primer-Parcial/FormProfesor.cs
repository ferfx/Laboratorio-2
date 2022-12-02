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
    public partial class FormProfesor : Form
    {
        private User usuarioLogueado;
        private FormLogin formLogin;
        public FormProfesor()
        {
            InitializeComponent();
        }

        public FormProfesor(User usuario, FormLogin formLogin) : this()
        {
            this.usuarioLogueado = usuario;
            this.formLogin = formLogin;
        }

        private void FormProfesor_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnMicuenta_Click(object sender, EventArgs e)
        {
            FormCuentaProfesor formCuenta = new FormCuentaProfesor(usuarioLogueado);

            formCuenta.ShowDialog();
        }

        private void FormProfesor_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Desea cerrar sesión?", "Cerrar sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                formLogin.Show();
            }
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
