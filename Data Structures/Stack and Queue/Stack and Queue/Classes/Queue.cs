using System;
using System.Collections.Generic;
using System.Text;

namespace Stack_and_Queue.Classes
{
    public class Queue
    {
        protected Node Front { get; set; }
        protected Node Rear { get; set; }

        /// <summary>
        /// Creates a new instance of the Queue class.
        /// </summary>
        /// <param name="node">The first node in the queue.</param>
        public Queue(Node node)
        {
            Front = node;
            Rear = node;
        }

        /// <summary>
        /// Adds a new node to the back of the Queue.
        /// </summary>
        /// <param name="node">The node being added.</param>
        public void Enqueue(Node node)
        {
            Rear.Next = node;
            Rear = node;
        }

        /// <summary>
        /// Removes the node at the front of the Queue.
        /// </summary>
        /// <returns>The front node.</returns>
        public Node Dequeue()
        {
            Node temp = Front;
            Front = Front.Next;
            temp.Next = null;
            return temp;
        }

        /// <summary>
        /// Retrieves the node at the front of the Queue.
        /// </summary>
        /// <returns>The front node.</returns>
        public Node Peek()
        {
            return Front;
        }
    }
}
