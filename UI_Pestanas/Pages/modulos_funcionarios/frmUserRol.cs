using CapaEntidades;
using CapaNegocios;
using System;
using System.Windows.Forms;

namespace UI_Pestanas.Pages.modulos_funcionarios {
    public partial class frmUserRol : Form {
        private int _idUsuario = 0;
        public frmUserRol(int idUsuario) {
            InitializeComponent();
            _idUsuario = idUsuario;
        }
        private void btnIngresar_Click(object sender, EventArgs e) {
            if (_idUsuario == 0) {
                MessageBox.Show("Hubo un error al cargar el usuario", "aviso", MessageBoxButtons.OK);
                return;
            }
            Roles_usuarios roles_Usuarios = new Roles_usuarios {
                Id_rol = Convert.ToInt32(cbRoles.SelectedValue.ToString()),
                Id_usuario = _idUsuario
            };

            if (N_Usuarios.ValidarRol(roles_Usuarios)) {
                MessageBox.Show("El usuario ya tiene asignado ese rol", "aviso", MessageBoxButtons.OK);
                return;
            }

            N_Usuarios.NuevoRole(roles_Usuarios);
            this.Close();
        }
        private void frmUserRol_Load(object sender, EventArgs e) {
            cbRoles.DataSource = N_Roles.Lista();
            cbRoles.DisplayMember = "Nombre";
            cbRoles.ValueMember = "IdRol";
        }
    }
}
