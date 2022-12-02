using Entidades;

namespace Ovelar_Primer_Parcial
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();

          
            

            
           
            
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void lblLogin_Click(object sender, EventArgs e)
        {

        }

        private void lblIngreseComo_Click(object sender, EventArgs e)
        {
            

        }

        private void lblUniversitaria_Click(object sender, EventArgs e)
        {

        }



        private void VaciarCampos()
        {
            foreach (Control control in this.Controls)
            {
                if (control is TextBox txtBox)
                {
                    txtBox.Text = string.Empty;
                }
            }
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {


            this.lblError.Visible = false;
            User valor = Sistema.LoginTipoUsuario(this.txtUsuario.Text,this.txtPassword.Text);



            if (valor != null) { 
               switch (valor.caracteristica)
                {
                    case "Admin":
                        
                        VaciarCampos();
                        
                        Form formAdmin = new FormAdmin(valor,this);
                        formAdmin.Show();
                        this.Hide();
                        break;


                    case "Profesor":
                        FormProfesor frmProfe = new FormProfesor(valor, this);
                        frmProfe.Show();
                        this.Hide();
                        VaciarCampos();
                        break;

                    case "Alumno":
                        FormAlumno formAlumno = new FormAlumno(valor, this);
                        formAlumno.Show();
                        this.Hide();
                        VaciarCampos();
                        break;

                    default:
                        this.lblError.Text = "ERROR: Usuario o contraseña incorrectos";
                        this.lblError.Visible = true;
                        VaciarCampos();
                        break;



                }

            }
            else
            {
                this.lblError.Text = "ERROR: Usuario o contraseña incorrectos";
                this.lblError.Visible = true;
                VaciarCampos();

            }














            /*
            if (1 == 2)
            {

            }
            else
            {
                this.lblError.Text = "ERROR: Usuario o contraseña incorrectos";
                this.lblError.Visible = true;
            }*/
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void lblError_Click(object sender, EventArgs e)
        {

        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            

            User aux = Sistema.ObtenerAdmin();

            this.txtUsuario.Text = aux.Usuario;
            this.txtPassword.Text = aux.Contraseña;
        }

        private void btnProfesor_Click(object sender, EventArgs e)
        {
            User aux = Sistema.ObtenerProfesor();

            this.txtUsuario.Text = aux.Usuario;
            this.txtPassword.Text = aux.Contraseña;
        }

        private void btnAlumno_Click(object sender, EventArgs e)
        {
            User aux = Sistema.ObtenerAlumno();

            this.txtUsuario.Text = aux.Usuario;
            this.txtPassword.Text = aux.Contraseña;
        }
    }
}