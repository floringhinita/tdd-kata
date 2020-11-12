using Xunit;

namespace RomanNumerals.Tests
{
    public class RomanNumeralTest
    {
        [Fact]
        public void TestClassExists()
        {
            var sut = new RomanNumerals();

            Assert.IsType<RomanNumerals>(sut);
        }
    }
}
