using CuadernosDigitales.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CuadernosDigitales
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
            CuadernosInicio cuadernosInicio = new CuadernosInicio();
            cuadernosInicio.Show();
            Application.Run();
        }
    }
}
