using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios {
    public class N_Reportes {
        readonly static D_Reportes d_Reportes = new D_Reportes();
        public static DataTable Usuarios(bool activo, string nombre) { 
            return d_Reportes.Usarios(activo, nombre);  
        }
        public static DataTable Ofertas(string idOferta) {
            return d_Reportes.Ofertas(idOferta);
        }
        public static DataTable NotasEstudiantes(string idAlumno) {
            return d_Reportes.NotasEstudiantes(idAlumno);
        }
        public static DataTable Profesores(string nombre, bool Activo) {
            return d_Reportes.Profesores(nombre,Activo);
        }
        public static DataTable Aulas(string estado) {
            return d_Reportes.Aulas(estado);
        }
    }
}
