using System;
using Xunit;
using AdjacentProduct;

namespace AdjacentProductTest
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(1, 2, 2)]
        [InlineData(2, 1, 2)]
        [InlineData(-2, 2, 2)]
        [InlineData(0, 0, 0)]
        public void TestReturnGreater(int first, int second, int expected)
        {
            Assert.Equal(expected, Program.ReturnGreater(first, second));
        }

    }
}
