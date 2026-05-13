
using Xunit;
using calculatorapp;

namespace calculatorapp_tests
{
    public class UnitTest1
    {
        [Fact]
        public void Add_ReturnsCorrectSum()
        {
            calculator calc = new calculator();
            int result = calc.Add(2, 3);
            Assert.Equal(5, result);
        }
    }
}
