using System;
using System.Collections.Generic;
using System.Text;

namespace Stack_and_Queue.Classes
{
    public class Node
    {
        public int Value { get; set; }
        public Node Next { get; set; } = null;

        /// <summary>
        /// Creates a new instance of the Node class.
        /// </summary>
        /// <param name="value">The Node's value.</param>
        public Node(int value)
        {
            Value = value;
        }
    }
}
