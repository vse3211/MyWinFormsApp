// Зависимости используемые в текущем файле
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

// Пространство имен приложения. Содержит все его классы
namespace MyWinFormsApp
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            // Установка стандартных значений (в данном случае false - отключено)
            Application.SetCompatibleTextRenderingDefault(false);
            // Запуск приложения
            Application.Run(new Form1());
        }
    }
}
