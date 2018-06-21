using Xunit;
using MultiBracketValidation;

namespace TestBracketValidation
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("([)]", false)]
        [InlineData("{}{Code}[Fellows](())", true)]
        [InlineData("][", false)]
        public void TestMultiBracketValidation(string input, bool expected)
        {
            Assert.Equal(expected, Program.MultiBracketValidation(input));
        }

        [Theory]
        [InlineData("([)]", true)]
        [InlineData("{}{Code}[Fellows](())", true)]
        [InlineData("", false)]
        public void TestHasRightBracket(string input, bool expected)
        {
            Assert.Equal(expected, Program.HasRightBrackets(input));
        }

        [Theory]
        [InlineData("([)]", 0)]
        [InlineData("Code{}{}[Fellows](())", 4)]
        [InlineData("", -1)]
        public void TestFindStartIndex(string input, int expected)
        {
            Assert.Equal(expected, Program.FindStartIndex(input));
        }

        [Theory]
        [InlineData("([)]", 0, 2)]
        [InlineData("{}{Code}[Fellows](())", 17, 20)]
        [InlineData("][", 1, -1 )]
        public void TestFindEndIndex(string input, int start, int expected)
        {
            Assert.Equal(expected, Program.FindEndIndex(input, start));
        }
    }
}
