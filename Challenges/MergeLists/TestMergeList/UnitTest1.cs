using LinkedLists.Classes;
using MergeLists;
using System;
using Xunit;

namespace TestMergeList
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(0, 1)]
        [InlineData(3, 9)]
        [InlineData(5, 4)]
        public void TestMerge(int position, int expected)
        {
            LinkedList list1 = new LinkedList(new Node(2));
            LinkedList list2 = new LinkedList(new Node(4));
            list1.Add(new Node(3));
            list1.Add(new Node(1));
            list2.Add(new Node(9));
            list2.Add(new Node(5));
            Node result = Program.MergeLists(list1, list2);
            for (int i = 0; i < position; i++)
            {
                result = result.Next;
            }
            Assert.Equal(expected, result.Value);
        }
    }
}
