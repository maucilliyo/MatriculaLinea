using CapaDatos;
using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios {
    public class N_Usuarios {

        static D_Usuarios _Usuarios = new D_Usuarios();
        /// <summary>
        /// funcion para validar y dar permisos a usuarios validos
        /// </summary>
        /// <param name="user"> parametro para enviar nombre de usuario</param>
        /// <param name="pass"> parametro para enviar contraseña</param>
        /// <returns>retorna un usuario con sus permisos</returns>
        /// <exception cref="Exception"> para capturar errores</exception>
        public static Usuario Aut_user(string user, string pass) {
            try {
                var _user = _Usuarios.Aut_user(user, pass);
                if (_user != null) {
                    _user.permisos = _Usuarios.permisos_Usuarios(_user.IdUsuario);
                    _user.Roles = _Usuarios.Roles_Usuarios(_user.IdUsuario);
                }
                return _user;
            }
            catch (Exception ex) {

                throw new Exception(ex.Message);
            }
        }
        /// <summary>
        /// Metodo para crear usuario
        /// </summary>
        /// <param name="user">objeto usuario </param>
        public static void Nuevo(Usuario user) {

            _Usuarios.Nuevo(user);
        }
        public static void Modificar(Usuario user) {

            _Usuarios.Modificar(user);
        }
        public static void NuevoRole(Roles_usuarios roles_Usuarios) {

            _Usuarios.NuevoRol(roles_Usuarios);
        }
        public static DataTable Lista() {
            return _Usuarios.Lista();
        }
        public  static bool ValidarRol(Roles_usuarios roles_Usuarios) {
           return _Usuarios.ValidarRol(roles_Usuarios);
        }
        public static Usuario GetById(int idUsuario) { 
            return _Usuarios.GetById(idUsuario);
        }
    }
}
