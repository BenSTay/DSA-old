using LinkedLists.Classes;
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
            Assert.Equal(node2, list.Head);
        }

        [Fact]
        public void TestFindNode()
        {
            LinkedList list = new LinkedList(new Node(0));
            for (int i = 1; i < 10; i++)
            {
                list.Add(new Node(i));
            }
            Assert.Equal(3, list.Find(3).Value);
        }

        [Fact]
        public void TestNodeDoesntExist()
        {
            Node node1 = new Node(1);
            Node node3 = new Node(3);
            LinkedList list = new LinkedList(node1);
            Assert.False(list.AddAfter(node3, list.Head.Next));
        }
    }
}
