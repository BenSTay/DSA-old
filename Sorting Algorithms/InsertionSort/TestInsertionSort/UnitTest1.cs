using System;
using Xunit;
using InsertionSort;

namespace TestInsertionSort
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(10)]
        [InlineData(50)]
        [InlineData(100)]
        public void TestRandomizerLength(int expected)
        {
            int[] array = Program.RandomArray(expected, 0, 10);
            Assert.Equal(expected, array.Length);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(5)]
        [InlineData(10)]
        public void TestRandomizerMinimum(int minimum)
        {
            int[] array = Program.RandomArray(10, minimum, minimum+2);
            foreach (int i in array)
            {
                Assert.True(i >= minimum);
            }
        }

        [Theory]
        [InlineData(0)]
        [InlineData(5)]
        [InlineData(10)]
        public void TestRandomizerMaximum(int maximum)
        {
            int[] array = Program.RandomArray(10, maximum - 2, maximum);
            foreach (int i in array)
            {
                Assert.True(i < maximum);
            }
        }

        [Fact]
        public void TestRandomInsertionSort()
        {
            int[] array = Program.RandomArray(256, 0, 65536);
            int[] sorted = Program.InsertionSort(array);
            long arraytotal = array[0];
            long sortedtotal = array[0];
            for (int i = 1; i < 256; i++)
            {
                arraytotal += array[i];
                sortedtotal += array[i];
                Assert.True(sorted[i] >= sorted[i - 1]);
            }
            Assert.Equal(arraytotal, sortedtotal);
        }

        [Fact]
        public void TestReverseInsertionSort()
        {
            int[] array = new int[] { 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 };
            int[] expected = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Assert.Equal(expected, Program.InsertionSort(array));

        }

        [Fact]
        public void TestSortedInsertionSort()
        {
            int[] array = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Assert.Equal(array, Program.InsertionSort(array));
        }
    }
}
