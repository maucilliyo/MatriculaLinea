using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades {
    public class Matricula {
        public Matricula() {
            this.Materias = new List<Materias>();
        }
        public int IdMatricula { get; set; }
        public int Id_estudiante { get; set; }
        public string Periodo { get; set; }
        public decimal Monto { get; set; }
        public DateTime Fecha { get; set; }
        public bool Congelada { get; set; }
        public List<Materias> Materias { get; set; }
    }
}
