namespace C_Sharp_Playground.Tests
{
using Xunit;
public class MathFunctionsTests
{
    [Fact]
    public void TestAdd()
    {
        // Arrange
        var mathFunctions = new MathFunctions();

        // Act
        var result = mathFunctions.Add(2, 3);

        // Assert
        Assert.Equal(5, result);
    }
}
public class MathFunctions
{
    public int Add(int a, int b)
    {
        return a + b;
    }
}
}