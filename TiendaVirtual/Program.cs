using AppGestionConsorcio.datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
            clsUsuario usuario = new clsUsuario();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Cache.User = "alonso123";
            usuario = usuario.consultarDatosUser();
            Cache.PerFoto = usuario.UsuFoto;
            Application.Run(new vtnInicioSesion());
        }
    }
}
