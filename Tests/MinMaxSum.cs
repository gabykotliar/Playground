using System;
using System.Collections.Generic;
using System.Linq;

using Playground;

using Xunit;
using Xunit.Abstractions;

namespace Tests
{
    public class MinMaxSumTests
    {
        private void MinMaxSum(List<int> arr)
        {
            int min = arr[1];
            int max = arr[1];
            long sum = 0;

            foreach (int i in arr)
            {
                if (i < min) min = i;
                if (i > max) max = i;

                sum += i;
            }

            output.WriteLine("{0} {1}", sum - max, sum - min);
        }

        private readonly ITestOutputHelper output;

        public MinMaxSumTests(ITestOutputHelper output)
        {
            this.output = output;
        }

        [Fact]
        public void EmptyStringIsTrue()
        {
            MinMaxSum(new[] { 1, 3, 5, 7, 9 }.ToList());
        }
    }
}
