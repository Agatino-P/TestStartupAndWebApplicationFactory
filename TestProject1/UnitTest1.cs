using Microsoft.AspNetCore.Mvc.Testing;
using TestStartupAndWebApplicationFactory;

namespace TestProject1;

public class UnitTest1:IClassFixture<MyWebFactory>    
{
    private readonly WebApplicationFactory<Program> _factory;

    public UnitTest1(MyWebFactory factory)
    {
        _factory = factory;
    }
    [Fact]
    public void Test1()
    {
        _factory.CreateClient();
        int b = 2;
    }
}
