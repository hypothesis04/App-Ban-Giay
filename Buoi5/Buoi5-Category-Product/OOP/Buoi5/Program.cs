using Buoi5.Views;
using Buoi51.Views;

namespace Buoi5
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            LoginV loginV = new LoginV();
            if (loginV.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new ProductV());
            }
        }
    }
}