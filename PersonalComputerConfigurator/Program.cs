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
        public static Model1 context = new Model1();
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new AuthorizationForm());
            }
            catch (Exception ex)
            {
                // Показываем сообщение об ошибке
                MessageBox.Show($"Ошибка: {ex.Message}\n{ex.StackTrace}");
            }
        }

    }
}
