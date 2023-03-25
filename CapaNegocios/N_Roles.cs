using CapaDatos;
using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios {
    public class N_Roles {
        readonly static D_Roles d_Roles = new D_Roles();
        public static List<Roles> Lista() { 
          return  d_Roles.Lista();    
        }
    }
}
