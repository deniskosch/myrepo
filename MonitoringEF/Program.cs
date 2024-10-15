using MonitoringEF.Data;
using System;
using System.Windows.Forms;

namespace MonitoringEF
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Создание и настройка контекста базы данных
            using (var context = new ApplicationDbContext())
            {
                // Создаем базу данных, если она не существует
                context.EnsureDatabaseCreated();
            }

            // Запуск главной формы
            Application.Run(new MainForm());
        }
    }
}
