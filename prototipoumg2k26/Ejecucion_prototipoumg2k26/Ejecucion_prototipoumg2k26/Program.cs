using System;
using System.Windows.Forms;
using CapaVista_prototipo2k26.Formas; // Directiva requerida

namespace Ejecucion_prototipo2k26
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new FrmEmpleados());
        }
    }
}