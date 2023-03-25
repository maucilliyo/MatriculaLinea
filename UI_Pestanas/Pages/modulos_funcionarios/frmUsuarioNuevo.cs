using CapaEntidades;
using CapaNegocios;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace UI_Pestanas.Pages.modulos_funcionarios {
    public partial class frmUsuarioNuevo : Form {
        private bool _isMod = false;
        private int _idUsuario = 0;
        public frmUsuarioNuevo(int idUsuario = 0) {
            InitializeComponent();
            _idUsuario = idUsuario;
            if (idUsuario != 0)
                LoaqModUser();
        }
        private void btnCrear_Click(object sender, System.EventArgs e) {

        }

        private void frmUsuarioNuevo_Load(object sender, EventArgs e) {

        }
        private void LoaqModUser() {

            var user = N_Usuarios.GetById(_idUsuario);
            if (user != null) {
                txtNombre.Text = user.Nombre;
                txtApellidos.Text = user.Apellidos;
                txtDireccion.Text = user.Direccion;
                txtuser.Text = user.User_name;
                txtpass.Text = user.User_pass;
                _isMod = true;
                btnIngresar.Text = "Modificar";
            }
        }
        private void btnIngresar_Click(object sender, EventArgs e) {
            if (txtNombre.Text.Trim() == string.Empty || txtApellidos.Text.Trim() == string.Empty
                || txtDireccion.Text.Trim() == string.Empty || txtpass.Text.Trim() == string.Empty 
                || txtuser.Text.Trim() == string.Empty) {
                MessageBox.Show("Debe ingresar todos los datos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Usuario usuario = new Usuario {
                IdUsuario = _idUsuario,
                Nombre = txtNombre.Text.Trim(),
                Apellidos = txtApellidos.Text.Trim(),
                Direccion = txtDireccion.Text.Trim(),
                User_name = txtuser.Text.Trim(),
                User_pass = txtpass.Text,
                permisos = new List<Permisos_usuarios>()
            };
            if (_isMod) {
                N_Usuarios.Modificar(usuario);
                MessageBox.Show("Usuario Modificado", "aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else {
                N_Usuarios.Nuevo(usuario);
                MessageBox.Show("Usuario creado", "aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            this.Close();
        }

        private void button1_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
