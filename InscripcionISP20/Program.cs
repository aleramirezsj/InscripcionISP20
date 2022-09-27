using Data.Interfaces;
using Data.Repositories;
using Desktop.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desktop
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //IUnitOfWork unitOfWork = new UnitOfWork();
            //var carrerasView = new CarrerasView(unitOfWork);
            Application.Run(new MenuPrincipalView());
        }
    }
}
