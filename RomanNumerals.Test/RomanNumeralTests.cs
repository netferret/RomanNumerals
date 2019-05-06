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
            var builder = new RomanNumeralBuilder();
            builder.CalculateRomanNumerals(input);

            Assert.Equal(builder.RomanNumeralOutput, expectedResult);
        }
    }
}
