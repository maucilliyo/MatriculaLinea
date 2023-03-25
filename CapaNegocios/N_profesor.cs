using CapaDatos;
using CapaEntidades;
using System.Data;

namespace CapaNegocios {
    public class N_profesor {
        readonly static D_profesores _Profesores = new D_profesores();
        public static void Nuevo(ProfesorMaterias profesorMaterias) {
          _Profesores.Nuevo(profesorMaterias);
        }
        public static DataTable Lista() {
          return _Profesores.Lista();
        }
        public static DataTable Lista_estudiantes(string idProfesor) {
          return  _Profesores.lista_alumnos(idProfesor);
        }
        public static DataTable Lista_materias(string idProfesor) {
            return _Profesores.lista_materias(idProfesor);
        }
    }
}
