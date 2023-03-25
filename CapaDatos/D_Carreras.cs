using CapaEntidades;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos {
    public class D_Carreras {
        public void Nueva(Carrera carrera) {
            using(var conn = ConexionSql.GetConnection()) {
                conn.Execute("SP_carrera_nueva", new { nombre = carrera.Nombre }, commandType: CommandType.StoredProcedure);         
            }
        }
        public void Modificar(Carrera carrera) {
            using (var conn = ConexionSql.GetConnection()) {
                conn.Execute("SP_carrera_modificar", new { nombre = carrera.Nombre,idCarrera = carrera.IdCarrera }, commandType: CommandType.StoredProcedure);
            }
        }
        public List<Carrera> GetCarreras(string nombre) {
            using (var conn = ConexionSql.GetConnection()) {
               return conn.Query<Carrera>("SP_carrera_lista", new {nombre }, commandType: CommandType.StoredProcedure).ToList();
            }
        }
    }
}
