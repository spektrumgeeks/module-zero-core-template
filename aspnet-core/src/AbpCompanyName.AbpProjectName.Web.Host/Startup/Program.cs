using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace AbpCompanyName.AbpProjectName.Web.Host.Startup
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BuildWebHost(args).Run();
        }

        public static IWebHost BuildWebHost(string[] args)
        {
            return WebHost.CreateDefaultBuilder(args)
                .UseUrls("http://localhost:21021")
                .UseStartup<Startup>()
                .Build();
        }
    }
}
