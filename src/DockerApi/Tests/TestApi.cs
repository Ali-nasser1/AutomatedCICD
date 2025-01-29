using DockerApi.Controllers;
using Xunit;

public class FirstTest
{
    [Fact]
    public void TestApiResponse()
    {
        var controller = new WeatherForecastController();
        var result = controller.Get();
        Assert.NotNull(result);
    }
}