using Libreria_Clases_TP_SYSACAD;

namespace Forms_TP_SYSACAD
{
    public partial class Form_LogIn : Form
    {
        private string _correoLogIn;
        private string _contrase�aLogIn;

        public string Correo
        {
            get
            {
                return _correoLogIn;
            }
            set 
            {
                _correoLogIn = value;
            }
        }

        public string Contrase�a
        {
            get
            {
                return _contrase�aLogIn;
            }
            set
            {
                _contrase�aLogIn = value;
            }
        }

        public Form_LogIn()
        {
            InitializeComponent();
            lblBienvenida.Text = "Bienvenido a SYSACAD";
            lblMail.Text = "Ingrese su direccion de email:";
            lblContrase�a.Text = "Ingrese su contrase�a:";
            btnIngresar.Text = "Ingresar";
            btnRegistrarse.Text = "Registrarse";

            lblBienvenida.Font = new Font("Arial", 15, FontStyle.Bold | FontStyle.Italic);
            lblMail.Font = new Font("Arial", 15);
            lblContrase�a.Font = new Font("Arial", 15);
        }

        private void Inicio_Sesion_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Text = "Iniciar Sesion";
        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Registro formRegistro = new Form_Registro();
            formRegistro.Show();
        }

        private void textBoxEmail_TextChanged(object sender, EventArgs e)
        {
            Correo = textBoxEmail.Text;
        }

        private void textBoxContrase�a_TextChanged(object sender, EventArgs e)
        {
            Contrase�a = textBoxContrase�a.Text;
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            bool resultadoValidacion = ValidadorIngresoUsuario.ValidarCorreoYContrase�a(_correoLogIn, _contrase�aLogIn);

            if (resultadoValidacion == true)
            {
                bool resultadoBusquedaUsuario = ValidadorIngresoUsuario.ComprobarSiUsuarioExiste(_correoLogIn, _contrase�aLogIn);
                
                if (resultadoBusquedaUsuario == true)
                {
                    this.Hide();
                    Form_Panel_Administracion formPanelAdministracion = new Form_Panel_Administracion();
                    formPanelAdministracion.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Usuario no encontrado. Por favor, registrese", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Asegurese de completar los campos solicitados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}