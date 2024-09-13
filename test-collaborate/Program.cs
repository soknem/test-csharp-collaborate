using System;
using System.Windows.Forms;
using test_collaborate.UI;

namespace test_collaborate
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Hello());
        }
    }
}
