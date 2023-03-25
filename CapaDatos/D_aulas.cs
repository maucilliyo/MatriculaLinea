using CapaEntidades;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos {
    public class D_aulas {
        public void Nueva(Aula aula) {
            using (var conn = ConexionSql.GetConnection()) { 
                conn.Open();
                conn.Execute("SP_Aulas_nueva", new { aula.Estado }, commandType: CommandType.StoredProcedure);
            }
        }
        public void Modificar(Aula aula) {
            using (var conn = ConexionSql.GetConnection()) {
                conn.Open();
                conn.Execute("SP_Aulas_Modificar", new { aula.Estado ,aula.IdAula }, 
                    commandType: CommandType.StoredProcedure);
            }
        }
        public List<Aula> GetAulas() {
            using (var conn = ConexionSql.GetConnection()) {
                return conn.Query<Aula>("SP_Aulas_lista", commandType: CommandType.StoredProcedure).ToList();
            }
        }
    }
}
