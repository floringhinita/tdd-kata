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

        [Fact]
        public void Given_Input_1_Should_Return_I()
        {
            var sut = new RomanNumerals();

            var result = sut.Convert(1);
            var expected = "I";

            Assert.Equal(expected, result);
        }
    }
}
