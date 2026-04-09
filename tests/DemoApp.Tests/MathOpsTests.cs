using DemoApp;
using Xunit;

namespace DemoApp.Tests;

public class MathOpsTests
{
    [Fact]
    public void Add_ReturnsExpectedSum()
    {
        var result = MathOps.Add(2, 3);

        Assert.Equal(5, result);
    }
}
