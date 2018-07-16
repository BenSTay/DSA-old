using System;
using Xunit;
using RepeatedWord;

namespace RepeatedWordTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("Once upon a time, there was a brave princess who...", "a")]
        [InlineData("It was a queer, sultry summer, the summer they electrocuted the Rosenbergs, and I didn’t know what I was doing in New York...", "summer")]
        public void TestRepeatedWords(string input, string expected)
        {
            Assert.Equal(expected, Program.RepeatedWord(input));
        }

        [Theory]
        [InlineData("Lorem ipsum dolor sit amet, consectetur adipiscing elit.")]
        [InlineData("Fergalicious definition make the boys go loco")]
        public void TestNoRepeatedWords(string input)
        {
            Assert.Equal("", Program.RepeatedWord(input));
        }

        [Fact]
        public void TestRepeatedWordsEmpty()
        {
            Assert.Equal("", Program.RepeatedWord(""));
        }
    }
}
