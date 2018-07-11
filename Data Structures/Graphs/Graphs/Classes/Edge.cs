using System;
using System.Collections.Generic;
using System.Text;

namespace Graphs.Classes
{
    public class Edge<T>
    {
        public Node<T> Node { get; set; }
        public int Weight { get; set; }

        public Edge(Node<T> node)
        {
            Node = node;
            Weight = 0;
        }

        public Edge(Node<T> node, int weight)
        {
            Node = node;
            Weight = weight;
        }
    }
}
