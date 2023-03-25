using CapaEntidades;
using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace CapaDatos {
    public class D_Programas {
        public List<Programa> Lista() {
            using (var conn = ConexionSql.GetConnection()) {
               return conn.Query<Programa>("SP_Programas_lista", commandType: CommandType.StoredProcedure).ToList();    
            }
        }
    }
}
