using OBM.App.Mappings;
using OBM.App.Views;
using System;
using System.Windows.Forms;

namespace OBM.App
{
    internal static class Program
    {
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            AutoMapperConfiguration.Configure();
            Application.Run(new Welcome());
        }
    }
}