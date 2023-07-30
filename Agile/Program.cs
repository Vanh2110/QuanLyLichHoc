namespace Agile
{
    internal static class Program
    {
        //Scaffold-DbContext 'Data Source=ADMIN;Initial Catalog=APPLICHHOC;Integrated Security=True;TrustServerCertificate=true' Microsoft.EntityFrameworkCore.SqlServer -OutputDir DomainClass -context DBContext -Contextdir Context -DataAnnotations -Force
        //TrustServerCertificate=true
        //Data Source=ADMIN;Initial Catalog=APPLICHHOC;Integrated Security=True;TrustServerCertificate=true
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Login());
        }
    }
}