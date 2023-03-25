using System.Collections.Generic;

namespace CapaEntidades {
    public class Ofertas {
        public Ofertas() { 
            this.Materias = new List<Ofertas_materias> { };
        }    
        public int IdOferta { get; set; }
        public int Id_Carrera { get; set; }
        public int Id_programa { get; set; }
        public string Tipo { get; set; }
        public List<Ofertas_materias> Materias { get; set; }
    }
}
