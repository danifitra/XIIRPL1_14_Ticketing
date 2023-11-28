using XIIRPL1_14_Ticketing.MasterForm;
using XIIRPL1_14_Ticketing.TansactionForm;

namespace XIIRPL1_14_Ticketing
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
            Application.Run(new FrmMasterJadwalPenerbangan());
        }
    }
}