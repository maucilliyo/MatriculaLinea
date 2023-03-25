using CapaDatos;
using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios {

    public class N_carreras {
        readonly static D_Carreras d_Carreras = new D_Carreras();
        public static void Nueva(Carrera carrera) {
			try {
                d_Carreras.Nueva(carrera);  
			}
			catch (Exception ex) {

				throw new Exception(ex.Message);
			}
        }
        public static void Modificar(Carrera carrera) {

            try {
                d_Carreras.Modificar(carrera);
            }
            catch (Exception ex) {

                throw new Exception(ex.Message);
            }
        }
        public static List<Carrera> GetCarreras(string nombre){
           return d_Carreras.GetCarreras(nombre);
        }
    }
}
