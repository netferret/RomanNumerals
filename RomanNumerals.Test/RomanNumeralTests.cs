using System;
using Xunit;

namespace RomanNumerals.Test
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(1674, "MDCLXXIV")]
        [InlineData(2012, "MMXII")]
        [InlineData(273, "CCLXXIII")]
        public void TestRomanNumerals(int input, string expectedResult)
        {
            Program.RomanNumeralOutput = string.Empty;
            Program.CalculateRomanNumerals(input);

            Assert.Equal(Program.RomanNumeralOutput, expectedResult);
        }
    }
}
