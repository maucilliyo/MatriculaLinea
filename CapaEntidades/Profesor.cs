using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades {
    public class Profesor {
        public Profesor() {
            this.Materias = new List<Materias>();
        }
        public int IdProfesor { get; set; }
        public int Id_usuario { get; set; }
        public List<Materias> Materias { get; set; }
    }
}
