using System;
using System.Collections.Generic;
using System.Text;

namespace Stack_and_Queue.Classes
{
    public class Stack
    {
        protected Node Top { get; set; }
        
        /// <summary>
        /// Creates a new instance of the Stack class.
        /// </summary>
        /// <param name="node">The first node in the Stack.</param>
        public Stack(Node node)
        {
            Top = node;
        }

        /// <summary>
        /// Places a new node at the top of the stack.
        /// </summary>
        /// <param name="node">The node being added.</param>
        public void Push(Node node)
        {
            node.Next = Top;
            Top = node;
        }

        /// <summary>
        /// Removes a node from the top of the stack.
        /// </summary>
        /// <returns>The top node.</returns>
        public Node Pop()
        {
            Node temp = Top;
            Top = Top.Next;
            temp.Next = null;
            return temp;
        }

        /// <summary>
        /// Retrieves the node at the top of the stack.
        /// </summary>
        /// <returns>The top node.</returns>
        public Node Peek()
        {
            return Top;
        }
    }
}
