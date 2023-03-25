using CapaDatos;
using CapaEntidades;

namespace CapaNegocios {
    public class N_Ofertas {
        static readonly D_oferta _Oferta = new D_oferta();  
        public static void Nueva(Ofertas ofertas) { 
                _Oferta.Nueva(ofertas);
        }
    }
}
