using System.Collections.Generic;

using Playground;

using Xunit;

namespace Tests
{
    public class DiagonalDifferenceTests
    {
        [Fact]
        public void EmptyStringIsTrue() 
        {
            List<List<int>> arr = new()
            { 
                new List<int> {11, 2, 4 },
                new List<int> {4, 5, 6 },
                new List<int> {10, 8, -12 }
            };

            var result = DiagonalDifference.Sum(arr);

            Assert.Equal(15, result);
        }

    }
}
