using CapaDatos;
using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios {
    public class N_Programa {

        readonly static D_Programas d_Programas = new D_Programas();
        public static List<Programa> Lista() {
            return d_Programas.Lista();
        }
    }
}
