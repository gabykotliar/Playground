using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xunit;

namespace Tests
{
    public class IterationTests
    {
        // 54-58 ms
        public int[] SetupArray() {

            var x = new int[50000000];
            Array.Fill(x, 0);
            return x;
        }

        // ~90 ms
        [Fact]
        public void For() {

            var arr = this.SetupArray();
            var l = arr.Length;

            for (int i = 0; i < l; i++)
            {
            }
        }

        // ~110 ms
        [Fact]
        public void Foreach() 
        {
            var arr = this.SetupArray();

            foreach (var item in arr)
            {

            }
        }

        // ~90 ms
        [Fact]
        public void While()
        {
            var arr = this.SetupArray();
            var l = arr.Length;
            int i = 0;

            while (i < l)
            {
                i++;
            }
        }
    }
}
