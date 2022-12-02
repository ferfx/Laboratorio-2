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
    public partial class FormAlumno : Form
    {
        private User usuarioLogueado;
        private FormLogin formLogin;
        public FormAlumno()
        {
            InitializeComponent();
        }

        public FormAlumno(User usuario, FormLogin formLogin) : this()
        {
            this.usuarioLogueado = usuario;
            this.formLogin = formLogin;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormAlumno_Load(object sender, EventArgs e)
        {

        }

        private void btnMicuenta_Click(object sender, EventArgs e)
        {
            FormCuentaAlumno formCuenta = new FormCuentaAlumno(usuarioLogueado);

            formCuenta.ShowDialog();
        }

        private void FormAlumno_FormClosing(object sender, FormClosingEventArgs e)
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
