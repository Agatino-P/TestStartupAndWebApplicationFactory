using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;
using TestStartupAndWebApplicationFactory;

namespace TestProject1;

public class MyWebFactory : WebApplicationFactory<Program>
{
    protected override void ConfigureWebHost(IWebHostBuilder builder)
    {
        builder.ConfigureServices(services =>
        {
            int a = 1;
        });
        base.ConfigureWebHost(builder);
    }
}