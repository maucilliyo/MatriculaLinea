using CapaEntidades;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace CapaDatos {
    public class D_Usuarios {
        public Usuario Aut_user(string user, string pass) {
            using (var conn = ConexionSql.GetConnection()) {
                return conn.Query<Usuario>("SP_UsuarioAut", 
                    new { user, pass }, 
                    commandType: CommandType.StoredProcedure).FirstOrDefault();
            }
        }
        public DataTable Lista() {
            DataTable data = new DataTable();
            using (var conn = ConexionSql.GetConnection()) {
                var reader = conn.ExecuteReader("SP_Usuarios_lista", commandType: CommandType.StoredProcedure);
                data.Load(reader);
            }
            return data;
        }
        public Usuario GetById(int idUsuario) {

            using (var conn = ConexionSql.GetConnection()) {
                return conn.Query<Usuario>("SP_Usuario_getById",
                    new { idUsuario },
                    commandType: CommandType.StoredProcedure).FirstOrDefault();
            }
        }
        public List<Permisos_usuarios> permisos_Usuarios(int IdUser) {
            using (var conn = ConexionSql.GetConnection()) {
                return conn.Query<Permisos_usuarios>("SP_UsuarioGetPermisos", new { IdUser }, commandType: CommandType.StoredProcedure).ToList();
            }
        }
        public List<Roles> Roles_Usuarios(int IdUser) {
            using (var conn = ConexionSql.GetConnection()) {
                return conn.Query<Roles>("SP_UsuarioGetRoles", new { IdUser }, commandType: CommandType.StoredProcedure).ToList();
            }
        }
        public bool Nuevo(Usuario user) {

            using (var conn = ConexionSql.GetConnection()) {
                conn.Open();
                using (var Transaction = conn.BeginTransaction()) {
                    try {
                        //Insertar usuario
                        var idUser = conn.ExecuteScalar("SP_UsuarioNuevo",
                           new {
                               nombre = user.Nombre,
                               apellidos = user.Apellidos,
                               direccion = user.Direccion,
                               user_name = user.User_name,
                               user_pass = user.User_pass,
                           },
                         commandType: CommandType.StoredProcedure,
                         transaction: Transaction);
                        //insertar permisos
                        foreach (var modulo in user.permisos) {
                            conn.ExecuteScalar("SP_UsuarioNuevoPermiso",
                                                new {
                                                    idModulo = modulo.IdModulo,
                                                    idUser
                                                },
                                                commandType: CommandType.StoredProcedure,
                                                transaction: Transaction);
                        }
                        Transaction.Commit();
                    }
                    catch (Exception ex) {
                        Transaction.Rollback();
                        throw new Exception(ex.Message);
                    }
                }
            }
            return true;
        }
        public bool Modificar(Usuario user) {

            using (var conn = ConexionSql.GetConnection()) {
                conn.Open();
                using (var Transaction = conn.BeginTransaction()) {
                    try {
                        //Insertar usuario
                        var idUser = conn.ExecuteScalar("SP_Usuario_MOdificar",
                           new {
                               idUsuario = user.IdUsuario,
                               nombre = user.Nombre,
                               apellidos = user.Apellidos,
                               direccion = user.Direccion,
                               user_name = user.User_name,
                               user_pass = user.User_pass,
                           },
                         commandType: CommandType.StoredProcedure,
                         transaction: Transaction);

                        Transaction.Commit();
                    }
                    catch (Exception ex) {
                        Transaction.Rollback();
                        throw new Exception(ex.Message);
                    }
                }
            }
            return true;
        }
        public void NuevoRol(Roles_usuarios roles_Usuarios) {

            using (var conn = ConexionSql.GetConnection()) {
                conn.Open();
                conn.Execute("SP_usuarios_roles_nuevos",
                    new { roles_Usuarios.Id_rol, roles_Usuarios.Id_usuario },
                    commandType: CommandType.StoredProcedure);
            }
        }
        public void ModRol(Roles_usuarios roles_Usuarios) {

            using (var conn = ConexionSql.GetConnection()) {
                conn.Open();
                conn.Execute("SP_usuarios_roles_nuevos",
                    new { roles_Usuarios.Id_rol, roles_Usuarios.Id_usuario },
                    commandType: CommandType.StoredProcedure);
            }
        }
        public bool ValidarRol(Roles_usuarios roles_Usuarios) {
            using (var conn = ConexionSql.GetConnection()) {
                return conn.Query<bool>("SP_Usuarios_rol_existe",
                                         roles_Usuarios,
                                         commandType: CommandType.StoredProcedure
                                        ).FirstOrDefault();
            }
        }
    }
}
