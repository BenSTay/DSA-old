using System;
using Stack_and_Queue.Classes;
using Xunit;

namespace Stack_and_Queue_Tests
{
    public class UnitTest1
    {
        [Fact]
        public void TestStackPeek()
        {
            Stack stack = new Stack(new Node(0));
            Assert.Equal(0, stack.Peek().Value);
        }

        [Fact]
        public void TestPush()
        {
            Stack stack = new Stack(new Node(0));
            stack.Push(new Node(1));
            Assert.False(stack.Peek().Next == null);
        }

        [Fact]
        public void TestPop()
        {
            Stack stack = new Stack(new Node(0));
            stack.Push(new Node(1));
            Node popped = stack.Pop();
            Assert.True(stack.Peek().Next == null && popped.Value == 1);
        }

        [Fact]
        public void TestQueuePeek()
        {
            Queue queue = new Queue(new Node(0));
            Assert.Equal(0, queue.Peek().Value);
        }

        [Fact]
        public void TestEnqueue()
        {
            Queue queue = new Queue(new Node(0));
            queue.Enqueue(new Node(1));
            Assert.False(queue.Peek().Next == null);
        }

        [Fact]
        public void TestDequeue()
        {
            Queue queue = new Queue(new Node(0));
            queue.Enqueue(new Node(1));
            Node dequeued = queue.Dequeue();
            Assert.True(queue.Peek().Next == null && dequeued.Value == 0);
        }
    }
}
