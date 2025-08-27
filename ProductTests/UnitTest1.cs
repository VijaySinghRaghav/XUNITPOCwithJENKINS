
using product;

namespace ProductTests;

public class UnitTest1
{
    [Fact]
    public void Add_TwoNumbers_ReturnsSum()
    {
        var result = Pro.Add(2, 3);
        Assert.Equal(5, result);
    }
}
