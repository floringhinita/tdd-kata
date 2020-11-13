using Xunit;

namespace RomanNumerals.Tests
{
    public class RomanNumeralTest
    {        
        [Theory]
        [InlineData(1, "I")]
        [InlineData(2, "II")]
        [InlineData(3, "III")]
        [InlineData(4, "IV")]
        [InlineData(5, "V")]
        [InlineData(10, "X")]
        [InlineData(11, "XI")]
        [InlineData(12, "XII")]
        [InlineData(13, "XIII")]
        [InlineData(14, "XIV")]
        [InlineData(15, "XV")]
        [InlineData(16, "XVI")]
        [InlineData(17, "XVII")]
        [InlineData(18, "XVIII")]
        [InlineData(19, "XIX")]
        [InlineData(20, "XX")]
        [InlineData(30, "XXX")]
        [InlineData(50, "L")]
        [InlineData(60, "LX")]
        [InlineData(85, "LXXXV")]
        [InlineData(96, "XCVI")]
        [InlineData(100, "C")]
        [InlineData(127, "CXXVII")]
        [InlineData(227, "CCXXVII")]
        [InlineData(427, "CDXXVII")]
        [InlineData(524, "DXXIV")]
        [InlineData(943, "CMXLIII")]
        [InlineData(1000, "M")]
        [InlineData(1943, "MCMXLIII")]
        public void Given_Input_Should_Return_Roman(int input, string expected)
        {
            var sut = new RomanNumerals();

            var result = sut.Convert(input);

            Assert.Equal(expected, result);
        }

    }
}
