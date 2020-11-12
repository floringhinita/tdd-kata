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

        [Fact]
        public void Given_Input_2_Should_Return_II()
        {
            var sut = new RomanNumerals();

            var result = sut.Convert(2);
            var expected = "II";

            Assert.Equal(expected, result);
        }

        [Fact]
        public void Given_Input_3_Should_Return_III()
        {
            var sut = new RomanNumerals();

            var result = sut.Convert(3);
            var expected = "III";

            Assert.Equal(expected, result);
        }
    }
}
