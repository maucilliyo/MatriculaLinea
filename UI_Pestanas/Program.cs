using System;
using System.Globalization;
using System.Windows.Forms;

namespace UI_Pestanas {
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main() {    
            //CULTURE INFO PARA FECHAS Y MONEDA
            var cultura = CultureInfo.GetCultureInfo("en-US");
            CultureInfo.DefaultThreadCurrentCulture = cultura;
            CultureInfo.DefaultThreadCurrentUICulture = cultura;
            //
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Para enviar el formulario de login
            var frmLogin = new frmLogin();
                Application.Run(frmLogin);
            //si es un usuario valido se cierra el formulario de login y se abre el siguiente
            if (frmLogin.Aut_user) {
                Application.Run(new frmMenu());
            }
        }
    }
}
