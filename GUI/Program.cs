using Sistema_Bancario.Config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Bancario
{
   static class Program
   {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


            CloseApplication.Run(new Login());
            //CloseApplication.Run(new VentanaPrincipal());
            //CloseApplication.Run(new Pruebas());

        }
    }
}
