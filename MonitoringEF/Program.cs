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

            // �������� � ��������� ��������� ���� ������
            using (var context = new ApplicationDbContext())
            {
                // ������� ���� ������, ���� ��� �� ����������
                context.EnsureDatabaseCreated();
            }

            // ������ ������� �����
            Application.Run(new MainForm());
        }
    }
}
