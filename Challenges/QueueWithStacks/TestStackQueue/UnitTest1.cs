using System;
using Xunit;
using Stack_and_Queue.Classes;
using QueueWithStacks.Classes;

namespace TestStackQueue
{
    public class UnitTest1
    {
        [Fact]
        public void TestEnqueue()
        {
            SQueue queue = new SQueue(new Node(0));
            Node testNode = new Node(100);
            queue.Enqueue(testNode);
            Assert.Equal(testNode, queue.Peek().Next);
        }

        [Fact]
        public void TestDequeue()
        {
            Node testNode1 = new Node(100);
            Node testNode2 = new Node(999);
            SQueue queue = new SQueue(testNode1);
            queue.Enqueue(testNode2);
            Assert.True(queue.Dequeue() == testNode1 && queue.Peek() == testNode2);
        }
    }
}
