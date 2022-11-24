using KutuphaneOtomasyonu.Forms;
using System;
using System.Windows.Forms;

namespace KutuphaneOtomasyonu
{
    internal static class Program
    {
        [STAThread]
        private static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frm_Login());
        }
    }
}