using Giao_Dien.View;

namespace Giao_Dien
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        // Data Source=DESKTOP-B52SRBN\SQLEXPRESS;Initial Catalog=APPLICHHOC;Integrated Security=True
        // Scaffold-DbContext 'Data Source=DESKTOP-B52SRBN\SQLEXPRESS;Initial Catalog=APPLICHHOC;Integrated Security=True; TrustServerCertificate=true' Microsoft.EntityFrameworkCore.SqlServer -OutputDir DomainClass -context DBContext -Contextdir Context -DataAnnotations -Force
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new FormDangNhap());
            //Application.Run(new FormQuanTriVien());
        }
    }
}