using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using PersonalComputerConfigurator.Forms;
using PersonalComputerConfigurator.Models;
using PersonalComputerConfigurator.Services;

namespace PersonalComputerConfigurator
{
    internal static class Program
    {
        public static PCConfiguratorModel context = new PCConfiguratorModel();
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new AuthorizationForm());
        }
    }
}
