using CapaNegocios;
using System;
using System.Windows.Forms;

namespace UI_Pestanas {
    public partial class frmLogin : Form {
        public bool Aut_user { get; set; }
        int ErroresInicio = 0 ;
        public frmLogin() {
            InitializeComponent();
        }
        private void btnIngresar_Click(object sender, EventArgs e) {
            VarGlovales.Usuario = N_Usuarios.Aut_user(txtuser.Text.Trim(), txtpass.Text);
            if (ErroresInicio >= 3) {
                MessageBox.Show("Demasiados intentos fallidos ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
            if (VarGlovales.Usuario != null) {
                Aut_user = true;
                this.Close();
            }
            else {
                MessageBox.Show("Error de inicio de secion, usuario o contraseña incorectos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ErroresInicio++;
            }
        }
        private void frmLogin_Load(object sender, EventArgs e) {

        }
        private void button1_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e) {
            frmAutoRegistro frmAutoRegistro = new frmAutoRegistro();    
            frmAutoRegistro.ShowDialog();
        }
    }
}
