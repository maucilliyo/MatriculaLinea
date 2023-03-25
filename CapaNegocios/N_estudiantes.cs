using CapaDatos;
using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios {
    public class N_estudiantes {
        readonly static D_estudiantes _Estudiantes = new D_estudiantes();
        public static void Nuevo() { 
            _Estudiantes.Nuevo();
        }
        public static DataTable Lista(string idUser) { 
        
          return _Estudiantes.Estudiantes(idUser);
        }
        public static DataTable Lista_materias(int idUser) {

            return _Estudiantes.Lista_materias(idUser);
        }
        public static void Actualizar_nota(AlumnosMaterias alumnosMaterias) {
            _Estudiantes.Actualizar_nota(alumnosMaterias);
        }
    }
}
