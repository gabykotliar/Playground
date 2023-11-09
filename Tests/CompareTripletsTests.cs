using System;
using System.Collections.Generic;

using Xunit;

namespace Tests
{
    public class CompareTripletsTests
    {
        [Fact]
        public void TestBruteForceMethod()
        {
            
        }

        public List<int> compareTriplets(List<int> a, List<int> b)
        {
            var result = new List<int> { 0, 0 };

            for (int i = 0; i < a.Count; i++) { 
                
                var partial = a[i].CompareTo(b[i]);

                if (partial < 0) { result[1]++; }
                else if (partial > 0) { result[0]++; }
            }

            return result;
        }
    }
}
