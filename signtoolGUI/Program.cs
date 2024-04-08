using System;
using System.Windows.Forms;

namespace signtoolGUI
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            HighDpi.Enable();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmMain());
        }
    }
}
