
namespace LearningDeveloperTests;
public class BasicTests
{
    //Using XUnit
    [Fact]
    public void CanAddTenAndTwenty()
    {
        //Arrange
        int a = 10, b = 20;
        int c;

        //Act
        c = a + b;

        //Assert
        //if (c != 30)
        //{
        //    throw new Exception("Can't Add!");
        //}
        Assert.Equal(30, c);
    }
    [Theory]
    [InlineData(10, 20, 30)]
    [InlineData(4, 2, 6)]
    public void CanAddAnyTwoIntegers(int a, int b, int expected)
    {
        int answer = a + b;

        Assert.Equal(expected, answer);
    }
}
