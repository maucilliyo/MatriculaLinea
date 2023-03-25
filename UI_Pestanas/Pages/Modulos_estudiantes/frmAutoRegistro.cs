using CapaEntidades;
using CapaNegocios;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace UI_Pestanas {
    public partial class frmAutoRegistro : Form {
        public frmAutoRegistro() {
            InitializeComponent();
        }

        #region Eventos
        private void button1_Click(object sender, EventArgs e) {
            this.Close();
        }
        private void frmAutoRegistro_Load(object sender, EventArgs e) {

        }
        private void btnIngresar_Click(object sender, EventArgs e) {
            if (txtNombre.Text.Trim() == string.Empty || txtApellidos.Text.Trim() == string.Empty
                || txtDireccion.Text.Trim() == string.Empty || txtpass.Text.Trim() == string.Empty || txtuser.Text.Trim() == string.Empty) {
                MessageBox.Show("Debe ingresar todos los datos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Nuevo();
        }
        #endregion

        #region Metodos
        private void Nuevo() {
            //
            Usuario usuario = new Usuario {
                Nombre = txtNombre.Text.Trim(),
                Apellidos = txtApellidos.Text.Trim(),
                Direccion = txtDireccion.Text.Trim(),
                User_name = txtuser.Text.Trim(),
                User_pass = txtpass.Text,
                permisos = new List<Permisos_usuarios>()
            };
            //permisos basicos para estudiante
            Permisos_usuarios Matricular = new Permisos_usuarios() {
                IdModulo = 1,
            };
            usuario.permisos.Add(Matricular);
            Permisos_usuarios mod_usuario_pass = new Permisos_usuarios() {
                IdModulo = 7,
            };
            usuario.permisos.Add(mod_usuario_pass);

            Permisos_usuarios mod_usuario_nombre = new Permisos_usuarios() {
                IdModulo = 8,
            };
            usuario.permisos.Add(mod_usuario_nombre);

            N_Usuarios.Nuevo(usuario);
            N_estudiantes.Nuevo();

            MessageBox.Show("Regitro completo", "Aviso", MessageBoxButtons.OK);
            this.Close();
        }
        /// <summary>
        /// EVENTO PARA LAS VALIDACIONES DEL NUEVO USUARIO
        /// </summary>
        /// <returns>verdadero si las validaciones pasaron , falso si hay errores de validacion</returns>
        private bool validar() {
            //TODO validaciones
            return true;
        }
        #endregion
    }
}
