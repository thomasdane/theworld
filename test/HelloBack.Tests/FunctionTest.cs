using Xunit;

namespace HelloBack.Tests
{
    public class FunctionTest
    {
        [Fact]
        public void TestToUpperFunction()
        {
            //Arrange
            var expected = "hello world";

            //Act
            var function = new Function();
            var actual = function.FunctionHandler();

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
