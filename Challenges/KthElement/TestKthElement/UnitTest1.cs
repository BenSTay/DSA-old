using System;
using Xunit;
using LinkedLists.Classes;

namespace TestKthElement
{
    public class UnitTest1
    {

        [Fact]
        public void TestOutOfRange()
        {
            LinkedList list = new LinkedList(new Node(2));
            list.Add(new Node(8));
            list.Add(new Node(3));
            list.Add(new Node(1));
            Assert.Throws<IndexOutOfRangeException>(() => list.KthElement(6));
        }

        [Theory]
        [InlineData(0, 2)]
        [InlineData(2, 3)]
        public void TestInRange(int k, int expected)
        {
            LinkedList list = new LinkedList(new Node(2));
            list.Add(new Node(8));
            list.Add(new Node(3));
            list.Add(new Node(1));
            Assert.Equal(expected, list.KthElement(k).Value);
        }
    }
}
