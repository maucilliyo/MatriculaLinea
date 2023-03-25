using CapaDatos;
using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios {
    public class N_matriculas {
        readonly static D_matriculas _Matriculas = new D_matriculas();
        public static void Nueva(Matricula matricula) { 
            _Matriculas.Nueva(matricula);
        }
    }
}
