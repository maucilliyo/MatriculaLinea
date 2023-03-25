using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios {
    public class Tests {

        public bool Conexion() {
			try {
                var conn = ConexionSql.GetConnection();
                return true;
			}
			catch (Exception ex) {
                throw new InvalidOperationException(ex.Message); 
            }
        }
    }
}
