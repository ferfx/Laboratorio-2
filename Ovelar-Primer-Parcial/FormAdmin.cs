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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Ovelar_Primer_Parcial
{
    public partial class FormAdmin : Form
    {

        private User usuarioLogueado;
        private FormLogin formLogin;
        public FormAdmin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public FormAdmin(User usuario, FormLogin formLogin) : this()
        {
            this.usuarioLogueado = usuario;
            this.formLogin = formLogin;
        }

        

        private void FormAdmin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void FormAdmin_Load(object sender, EventArgs e)
        {

        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormAdmin_FormClosing(object sender, FormClosingEventArgs e)
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

        private void btnMicuenta_Click(object sender, EventArgs e)
        {
            FormCuentaAdmin formCuenta = new FormCuentaAdmin(usuarioLogueado);

            formCuenta.ShowDialog();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripSplitButton1_ButtonClick(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripSplitButton1_ButtonClick_1(object sender, EventArgs e)
        {

        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.dgvAdmines.Visible = false;
            
            
            FormAltaAdmin frmAltaAdmin = new FormAltaAdmin();
          




            frmAltaAdmin.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnListarAdmines_Click(object sender, EventArgs e)
        {
            this.dgvAdmines.DataSource = null;
            this.dgvAdmines.DataSource = Sistema.ListaAdmines;
            this.dgvAdmines.Visible = true;


        }

        private void profesorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAltaProfesor frmAltaProfe = new FormAltaProfesor();
            frmAltaProfe.ShowDialog();  
        }

        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {

        }

        private void alumnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAltaAlumno frmAltaAlumno = new FormAltaAlumno();
            frmAltaAlumno.ShowDialog();
        }

        private void dgvAdmines_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FormEstadoMaterias frm = new FormEstadoMaterias();
            frm.ShowDialog();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormAltaMateria frm = new FormAltaMateria();
            frm.ShowDialog();
        }

        private void profesorAMateriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormProfesorAmateria frm = new FormProfesorAmateria();
            frm.ShowDialog(); 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bool objetivo=true;

            foreach (User a in Sistema.ListaAlumnos)
            {
                objetivo = JSON.SerializarJSON(a);
            }
            if (objetivo == true)
            {
                MessageBox.Show("TAREA EJECTUADA CORRECTAMENTE");
            }
            else MessageBox.Show("FALLO LA SERIALIZACION");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            Sistema.ListaAlumnosJson = JSON.DeserializarJSON();
            foreach(User aux in Sistema.ListaAlumnosJson)
            {
                UserDao.AddAlumno(aux.Usuario,aux.Contraseña,aux.Nombre,aux.Apellido,aux.Edad,aux.Dni);
            }
            MessageBox.Show("ALUMNOS AGREGADOS A LA BASE DE DATOS");
            
        }
    }
}
