using CapaEntidades;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos {
    public  class D_Roles {
        public List<Roles> Lista() {
            using (var conn = ConexionSql.GetConnection()) {
                return conn.Query<Roles>("SP_roles_lista", commandType: CommandType.StoredProcedure).ToList();   
            }
        }
    }
}
