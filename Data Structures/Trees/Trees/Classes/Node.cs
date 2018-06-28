using System;
using System.Collections.Generic;
using System.Text;

namespace Trees.Classes
{
    public class Node<T>
    {
        public T Value { get; set; }
        public Node<T> LeftChild { get; set; }
        public Node<T> RightChild { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        public Node(T value)
        {
            Value = value;
        }
    }
}
