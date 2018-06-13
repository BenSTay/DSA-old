using LinkedLists.Classes;
using System;
using Xunit;

namespace LinkedListTests
{
    public class UnitTest1
    {

        [Fact]
        public void TestAddNode()
        {
            Node node1 = new Node(1);
            Node node2 = new Node(2);
            LinkedList list = new LinkedList(node1);
            list.Add(node2);
            Assert.Equal(node2, list.Find(2));
        }

        [Fact]
        public void TestNodeDoesntExist()
        {
            Node node1 = new Node(1);
            Node node3 = new Node(3);
            LinkedList list = new LinkedList(node1);
            Assert.False(list.AddAfter(node3, list.Find(2)));
        }
    }
}
