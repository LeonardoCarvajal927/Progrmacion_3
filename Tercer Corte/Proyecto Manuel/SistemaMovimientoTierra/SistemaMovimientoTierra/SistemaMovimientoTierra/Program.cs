using SistemaMovimientoTierra.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaMovimientoTierra
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

            // Temporal: ejecutar solo el formulario de cálculo de volumen
            Application.Run(new FrmCalculoVolumen());

            // Formulario real del sistema:
            // Application.Run(new FrmLogin());
        }
    }
}