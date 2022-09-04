using System;
using System.Windows.Forms;
using TiendaVirtual.Logica;
using TiendaVirtual.Ventanas;

namespace TiendaVirtual
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new vtnInicioSesion());
        }
    }
}
