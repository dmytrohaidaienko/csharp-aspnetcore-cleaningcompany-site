namespace csharp_aspnetcore_cleaningcompany_site
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            app.UseDefaultFiles();
            app.UseStaticFiles();
            app.MapDefaultControllerRoute();

            app.Run();
        }
    }
}