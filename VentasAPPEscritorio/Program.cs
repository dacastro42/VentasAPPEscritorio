using VentasAPPEscritorio.views;
namespace VentasAPPEscritorio
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
            Application.Run(new UC_Login()/*new Form1()*/ /*new UC_Vendedores()*/ /*new UC_Ventas()*/);
        }
    }
}