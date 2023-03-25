using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using static Dapper.SqlMapper;

namespace CapaDatos {
    public class ConexionSql {
        /// <summary>
        /// Clase para optener la conexion al servidor sql
        /// la cadena esta encriptada
        /// </summary>
        /// <returns>Retorna la conexion de una instancia SQL server</returns>
        /// <exception cref="InvalidOperationException">Caprurar errores de conexion</exception>
        /// 
        static readonly string Servidor; //Nombre o ip del servidor
        static readonly string Instancia; //Nombre de la instancia sql
        static readonly string BaseDatos; //Nombre de la base de datos
        static readonly string User; //Usuario de acceso
        static readonly string Password; //Contraseña de usuario de acceso
        public ConexionSql() {

           
        }
        public static SqlConnection GetConnection() {
            //CREAMOS EL OBJETO DE CONEXION
            SqlConnection connection = new SqlConnection {
                ConnectionString = Encriptacion.Desencriptar(ConfigurationManager.AppSettings["StringConexion"])
            };
            //NOS CONECTAMOS
            try {
                //VALORAMOS EL ESTADO DELA CONEXION
                if (connection.State == ConnectionState.Open) {
                    connection.Close();
                }
                else {
                    connection.Open();
                }
            }
            catch (Exception ex) {
                //SI ALGO SALIO MAL DEVOLVEMOS EL ERROR
                throw new InvalidOperationException("ERROR DE CONEXION CON EL SERVIDOR " + ex.Message);
            }
            finally {
                connection.Close();
            }
            return connection;
        }
    }
}
