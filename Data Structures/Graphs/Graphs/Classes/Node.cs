using System;
using System.Collections.Generic;
using System.Text;

namespace Graphs.Classes
{
    public class Node<T>
    {
        public T Value { get; set; }
        public List<Node<T>> Children { get; set; }
        public bool Visited { get; set; }

        /// <summary>
        /// Creates a new instance of the Node class.
        /// </summary>
        /// <param name="value">The value being held by the Node.</param>
        public Node(T value)
        {
            Value = value;
            Children = new List<Node<T>>();
        }

    }
}
