using System;
using System.Collections.Generic;
using System.Linq;

using Playground;

using Xunit;
using Xunit.Abstractions;

namespace Tests
{
    public class PlusMinusTests
    {
        private void PlusMinus(List<int> arr)
        {
            double pos = 0, neg = 0, zero = 0, total = 0;

            foreach (int i in arr)
            {
                if (i > 0) pos++;
                else if (i < 0) neg++;
                else zero++;

                total++;
            }

            output.WriteLine("{0:N6}", pos / total);
            output.WriteLine("{0:N6}", neg / total);
            output.WriteLine("{0:N6}", zero / total);
        }

        private readonly ITestOutputHelper output;

        public PlusMinusTests(ITestOutputHelper output)
        {
            this.output = output;
        }

        [Fact]
        public void EmptyStringIsTrue()
        {
            PlusMinus(new[] { 1, 1, 0, -1, -1 }.ToList());
        }
    }
}
