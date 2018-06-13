using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedLists.Classes
{
    public class Node
    {
        public int Value { get; set; }
        public Node Next { get; set; } = null;

        /// <summary>
        /// Creates a new Node with a given value.
        /// </summary>
        /// <param name="value">The value of the Node.</param>
        public Node(int value)
        {
            Value = value;
        }
    }
}
