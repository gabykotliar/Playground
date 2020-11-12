using Playground;

using Xunit;

namespace Tests
{
    public class ValidParenthesesTests
    {
        [Fact]
        public void EmptyStringIsTrue() 
        {
            var valid = new ValidParentheses().IsValid(string.Empty);

            Assert.True(valid);
        }

        [Theory]
        [InlineData("()", true)]
        [InlineData("(", false)]
        [InlineData(")", false)]
        [InlineData("{}", true)]
        [InlineData("[]", true)]
        [InlineData("()[]{}", true)]
        [InlineData("{[]}", true)]
        [InlineData("(]", false)]
        [InlineData("([)]", false)]
        public void TestAlgorithm(string s, bool expected)
        {
            var func = new ValidParentheses();
            
            var actual = func.IsValid(s);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("()", true)]
        [InlineData("(", false)]
        [InlineData(")", false)]
        [InlineData("{}", true)]
        [InlineData("[]", true)]
        [InlineData("()[]{}", true)]
        [InlineData("{[]}", true)]
        [InlineData("(]", false)]
        [InlineData("([)]", false)]
        public void TestNoMap(string s, bool expected)
        {
            var func = new ValidParentheses();

            var actual = func.IsValidNoMap(s);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("()", true)]
        [InlineData("(", false)]
        [InlineData(")", false)]
        [InlineData("{}", true)]
        [InlineData("[]", true)]
        [InlineData("()[]{}", true)]
        [InlineData("{[]}", true)]
        [InlineData("(]", false)]
        [InlineData("([)]", false)]
        public void TestNoGenerics(string s, bool expected)
        {
            var func = new ValidParentheses();

            var actual = func.IsValidNoGenerics(s);

            Assert.Equal(expected, actual);
        }
    }
}
