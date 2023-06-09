using Microsoft.Extensions.Configuration;

namespace TestStartupAndWebApplicationFactory;

public class Program
{
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }
        public static IHostBuilder CreateHostBuilder(string[] args)
        {
            return Host.CreateDefaultBuilder(args).
            ConfigureWebHostDefaults(x => x.UseStartup<Startup>());
        }

}
