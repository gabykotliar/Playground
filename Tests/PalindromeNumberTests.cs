using Playground;
using System;
using Xunit;

namespace Tests
{
    public class PalindromeNumberTests
    {
        [Fact]
        public void TestReverseMethod()
        {
            ValidateTheory(new PalindromeNumber().IsPalindromeReverse);
        }

        [Fact]
        public void TestReverseHalfMethod()
        {
            ValidateTheory(new PalindromeNumber().IsPalindromeReverseHalf);
        }

        private void ValidateTheory(Func<int, bool> isPalindromeMethod)
        {
            // true
            Assert.True(isPalindromeMethod(121), "true test failed");
            
            // false
            Assert.False(isPalindromeMethod(1211), "false test failed");
            
            // negative
            Assert.False(isPalindromeMethod(-121), "negative test failed");

            // pair digits
            Assert.True(isPalindromeMethod(1221), "pair digits test failed");

            // big number
            Assert.True(isPalindromeMethod(123454321), "big number test failed");

            // trailing zero
            Assert.False(isPalindromeMethod(10), "trailing zero test failed");

            // zero
            Assert.True(isPalindromeMethod(0), "zero test failed");
        }
    }
}
