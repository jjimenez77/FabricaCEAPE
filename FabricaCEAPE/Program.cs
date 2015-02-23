using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using FabricaCEAPE.Clases;
using FabricaCEAPE.Datos;
using FabricaCEAPE.Vistas;

namespace FabricaCEAPE
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 

        public static List<Login> logins = new List<Login>();


        [STAThread]
        static void Main()
        {
            logins = DatosLogin.getLogins();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Vistas.FrmPrincipal());
            Application.Run(new Vistas.FrmLogin());
        }
    }
}
