using Xunit;
using System;

namespace Tests
{
    public class LongestCommonPrefixTests
    {
        [Fact]
        public void TestWordByWordMethod() 
        {
            ValidateTheoryFor(new Playground.LongestCommonPrefix().GetPrefixWordByWord);
        }

        [Fact]
        public void TestCharByCharMethod()
        {
            ValidateTheoryFor(new Playground.LongestCommonPrefix().GetPrefixCharByChar);
        }

        private void ValidateTheoryFor(Func<string[], string> func) 
        {
            Assert.Equal("fl", func(new[] { "flower", "flow", "flight" }));
            Assert.Equal("fl", func(new[] { "flower", "fl", "flow" }));
            Assert.Equal("", func(new[] { "dog", "racecar", "car" }));

            // one char
            Assert.Equal("", func(new[] { "a", "b" }));

            // first char
            Assert.Equal("d", func(new[] { "dog", "dace", "dude" }));

            // first word is the common prefix
            Assert.Equal("a", func(new[] { "a", "ab" }));

            // al equal
            Assert.Equal("dog", func(new[] { "dog", "dog" }));

            // single
            Assert.Equal("a", func(new[] { "a" }));

            // char by char search optimum scenario
            Assert.Equal("", func(new[] { "this is a long frase a", 
                                          "this is a long frase b",
                                          "this is a long frase c",
                                          "this is a long frase d",
                                          "dif" }));
            
            Assert.Equal("", func(Array.Empty<string>()));
            Assert.Equal("", func(new[] { string.Empty }));

        }
    }
}
