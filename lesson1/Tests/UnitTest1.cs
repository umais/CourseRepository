using Xunit;

namespace Tests;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
         bool result=true;
        Assert.True(result,"Result is true");
    }
}