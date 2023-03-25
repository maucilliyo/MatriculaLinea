using System;
using System.Collections.Generic;

namespace CapaEntidades {
    public class Usuario {
        public Usuario() { 
            this.permisos = new List<Permisos_usuarios> ();
            this.Roles = new List<Roles> ();
        }
        public int IdUsuario { get; set; }
        public string User_name { get; set; }
        public string User_pass { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Direccion { get; set; }
        public string TipoIniciado { get; set; }
        public DateTime Fecha_ingreso { get; set; }
        public DateTime Fecha_modificacion { get; set; }
        public  List<Permisos_usuarios> permisos { get; set; }
        public List<Roles> Roles { get; set; }
    }
}
