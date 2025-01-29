using Xunit;

namespace DockerApi.Tests;

public class SampleTests
{
    [Fact]
    public void TestAddition()
    {
        int a = 2;
        int b = 3;
        Assert.Equal(5, a + b);
    }
}