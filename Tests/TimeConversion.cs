using System;
using System.Collections.Generic;
using System.Linq;

using Playground;

using Xunit;
using Xunit.Abstractions;

namespace Tests
{
    public class TimeConversionTests
    {
        private string TimeConversion(string s)
        {
            var time = s.Take(8);
            var ampm = s.TakeLast(2);

            DateTime t;
            DateTime.TryParse(s, out t);

            var ts = t.TimeOfDay.ToString("c");

            return ts;

           // return string.Empty;
        }

        private readonly ITestOutputHelper output;

        public TimeConversionTests(ITestOutputHelper output)
        {
            this.output = output;
        }

        [Fact]
        public void EmptyStringIsTrue()
        {
            var t = TimeConversion("07:05:45PM");

            Assert.Equal("19:05:45", t);
        }
    }
}
