using Playground;
using System;
using Xunit;

namespace Tests
{
    public class ReverseIntegerests
    {
        [Fact]
        public void TestUsingDecimalPartMethod() 
        {
            ValidateTheory(new ReverseInteger().ReverseUsingDecimalPart);
        }

        [Fact]
        public void TestWithStringMethod()
        {
            ValidateTheory(new ReverseInteger().ReverseWithString);
        }

        [Fact]
        public void TestWithModAndReductionMethod()
        {
            ValidateTheory(new ReverseInteger().ReverseWithModAndReduction);
        }

        private void ValidateTheory(Func<int, int> reverse) 
        {
            // basic case
            Assert.Equal(123, reverse(321));

            // Negative
            Assert.Equal(-321, reverse(-123));

            // Trailing Zero
            Assert.Equal(21, reverse(120));

            // Big Number (expect 0 on overflow)
            Assert.Equal(0, reverse(1534236469));

            // basic case
            Assert.Equal(123, reverse(321));

            // basic case
            Assert.Equal(123, reverse(321));

            // basic case
            Assert.Equal(123, reverse(321));
        }

        //[Fact]
        //public void Test1()
        //{
        //    Assert.Equal(123, new ReverseInteger().Reverse1(321));
        //    Assert.Equal(123, new ReverseInteger().Reverse2(321));
        //    Assert.Equal(123, new ReverseInteger().Reverse3(321));
        //}

        //[Fact]
        //public void Negative()
        //{
        //    Assert.Equal(-321, new ReverseInteger().Reverse1(-123));
        //    Assert.Equal(-321, new ReverseInteger().Reverse2(-123));
        //    Assert.Equal(-321, new ReverseInteger().Reverse3(-123));
        //}

        //[Fact]
        //public void TrailingZero()
        //{
        //    Assert.Equal(21, new ReverseInteger().Reverse1(120));
        //    Assert.Equal(21, new ReverseInteger().Reverse2(120));
        //    Assert.Equal(21, new ReverseInteger().Reverse3(120));
        //}

        //[Fact]
        //public void BigNumber()
        //{ // expect 0 if overflow
        //    Assert.Equal(0, new ReverseInteger().Reverse1(1534236469));
        //    Assert.Equal(0, new ReverseInteger().Reverse2(1534236469));
        //    Assert.Equal(0, new ReverseInteger().Reverse3(1534236469));
        //}  
    }
}
