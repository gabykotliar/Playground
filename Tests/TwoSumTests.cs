using System;
using Xunit;

namespace Tests
{
    public class TwoSumTests
    {
        [Fact]
        public void TestBruteForceMethod()
        {
            ValidateTheory(new Playground.TwoSum().TwoSumBruteForce);
        }

        [Fact]
        public void TestHashAndSearchMethod()
        {
            ValidateTheory(new Playground.TwoSum().TwoSumHashAndSearch);
        }

        [Fact]
        public void TestHashOnePassMethod()
        {
            ValidateTheory(new Playground.TwoSum().TwoSumHashOnePass);
        }

        private void ValidateTheory(Func<int[], int , int[]> twoSum) 
        {
            // ??
            Assert.Equal(new[] { 0, 2 }, twoSum(new[] { 2, 7, 11, 15 }, 13));
        }
    }
}
