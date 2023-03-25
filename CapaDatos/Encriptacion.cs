using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos {
    public class Encriptacion {
        #region metodos

        /// <summary>
        /// Metodo de encriptar texto
        /// </summary>
        /// <param name="P_texto">Variable de tipo string</param>
        /// <returns>Resultado encriptado</returns>
        public static string Encriptar(string P_texto) {
            //Proceso de encriptacion
            byte[] encryted = System.Text.Encoding.Unicode.GetBytes(P_texto);
            string result = Convert.ToBase64String(encryted);

            //Retorna valor encriptado
            return result;
        }

        /// <summary>
        /// Método para desencriptar texto
        /// </summary>
        /// <param name="P_texto">Variable de tipo string</param>
        /// <returns>Resultado desencriptado</returns>
        public static string Desencriptar(string P_texto) {

            //Proceso de desencriptacion
            byte[] decryted = Convert.FromBase64String(P_texto);
            string result = Encoding.Unicode.GetString(decryted);

            return result;
        }

        #endregion
    }
}
