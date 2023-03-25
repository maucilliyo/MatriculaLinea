using CapaDatos;
using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios {

    public class N_materias {
        readonly static D_Materias d_materias = new D_Materias();
        public static void Nueva(Materias materias) {
            try {
                d_materias.Nueva(materias);
            }
            catch (Exception ex) {

                throw new Exception(ex.Message);
            }
        }
        public static void Modificar(Materias materias) {

            try {
                d_materias.Modificar(materias);
            }
            catch (Exception ex) {

                throw new Exception(ex.Message);
            }
        }
        public static List<Materias> GetMaterias(string nombre) {
            return d_materias.GetMaterias(nombre);
        }
    }
}
