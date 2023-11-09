using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BenchmarkDotNet.Attributes;

namespace Benchmarks
{
    public class LongestCommonPrefixBenchmarks
    {
        private readonly string[] data = new[] { "flower", "flow", "flight" };

        [Benchmark]
        public string b()
        {
            return new Playground.LongestCommonPrefix().GetPrefixWordByWord(data);
        }
    }
}
