using Xunit;
using System;

namespace Tests
{
    public class RomanToIntegerTests
    {
        [Fact]
        public void TestConvertMethod()
        {
            Func<string, int> convert = new Playground.RomanToInteger().Convert;

            // single numbers
            Assert.Equal(1, convert("I"));
            Assert.Equal(5, convert("V"));
            Assert.Equal(10, convert("X"));
            Assert.Equal(50, convert("L"));
            Assert.Equal(100, convert("C"));
            Assert.Equal(500, convert("D"));
            Assert.Equal(1000, convert("M"));

            // simple additions
            Assert.Equal(3, convert("III"));
            Assert.Equal(200, convert("CC"));
            Assert.Equal(30, convert("XXX"));

            // additions
            Assert.Equal(15, convert("XV"));
            Assert.Equal(58, convert("LVIII"));
            Assert.Equal(1737, convert("MDCCXXXVII"));

            // decrements
            Assert.Equal(4, convert("IV"));
            Assert.Equal(9, convert("IX"));
            Assert.Equal(1994, convert("MCMXCIV"));
        }
    }
}
