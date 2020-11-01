using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataTests
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
            //Application.Run(new DataSourceTest());
            //Application.Run(new ComboBoxTest());
            //Application.Run(new TextBoxTest());
            //Application.Run(new MenuDesplegable());
            Application.Run(new VentasEncDet());
        }
    }
}
