using CapaDatos;
using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios {
    public class N_aulas {
        readonly static D_aulas d_Aulas = new D_aulas();
        public static void Nueva(Aula aula) { 
            d_Aulas.Nueva(aula);
        }
        public static void Modificar(Aula aula) {
            d_Aulas.Modificar(aula);
        }
        public static List<Aula> GetAulas() {
            return d_Aulas.GetAulas();
        }
        public static DataTable Estados() { 
            DataTable dt = new DataTable();
            dt.Columns.Add("Estado");
            dt.Rows.Add("Perfecto");
            dt.Rows.Add("Regular");
            dt.Rows.Add("Mal");
            return dt;
        }
    }
}
