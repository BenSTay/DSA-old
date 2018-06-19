using System;
using System.Collections.Generic;
using System.Text;
using Stack_and_Queue.Classes;

namespace QueueWithStacks.Classes
{
    public class SQueue
    {
        Stack IStack;
        Stack OStack;

        /// <summary>
        /// Creates a new instance of the SQueue class with an initial node.
        /// </summary>
        /// <param name="node">The initial node.</param>
        public SQueue(Node node)
        {
            IStack = new Stack(node);
            OStack = new Stack(IStack.Pop());
        }

        /// <summary>
        /// Moves the contents from one stack to another.
        /// </summary>
        /// <param name="s1">The stack which nodes are being moved from.</param>
        /// <param name="s2">The stack which nodes are being moved to.</param>
        public void SwapStacks(Stack s1, Stack s2)
        {
            while (s1.Peek() != null)
            {
                s2.Push(s1.Pop());
            }
        }

        /// <summary>
        /// Adds a new node to the rear of the SQueue.
        /// </summary>
        /// <param name="node">The node being added.</param>
        public void Enqueue(Node node)
        {
            SwapStacks(OStack, IStack);
            IStack.Push(node);
        }

        /// <summary>
        /// Removes the node at the front of the SQueue.
        /// </summary>
        /// <returns>The removed node.</returns>
        public Node Dequeue()
        {
            SwapStacks(IStack, OStack);
            return OStack.Pop();
        }

        /// <summary>
        /// Returns a reference to the node at the front of the SQueue.
        /// </summary>
        /// <returns>The node at the front of the SQueue.</returns>
        public Node Peek()
        {
            SwapStacks(IStack, OStack);
            return OStack.Peek();
        }
    }
}
