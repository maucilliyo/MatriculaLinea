using CapaEntidades;
using System.Text.RegularExpressions;

namespace UI_Pestanas {
    public class VarGlovales {
        public static Usuario Usuario { get; set; }
        public static bool ValidarFormatoHora(string fecha) {
            string pattern = @"^(0?[0-9]|1[0-9]|2[0-3]):([0-5][0-9])$"; 
            if (Regex.IsMatch(fecha, pattern)) {
                return true;
            }
            return false;
        }
        public static bool ValidarMontos(string monto) {
            string pattern = @"^[0-9]{1,3}(?:,?[0-9]{3})*(?:\.[0-9]{2})?$";
            if (Regex.IsMatch(monto, pattern)) {
                return true;
            }
            return false;
        }
    }
}
