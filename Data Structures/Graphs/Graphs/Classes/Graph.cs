using System;
using System.Collections.Generic;
using System.Text;

namespace Graphs.Classes
{
    public class Graph<T>
    {
        protected List<Node<T>> AdjacencyList { get; set; }

        /// <summary>
        /// Creates a new instance of the Graph class.
        /// </summary>
        /// <param name="node">The first node in the Graph.</param>
        public Graph(Node<T> node)
        {
            AdjacencyList = new List<Node<T>>();
            AddEdge(node);
        }

        /// <summary>
        /// Adds a node to the Graph.
        /// </summary>
        /// <param name="node">The node being added.</param>
        public void AddEdge(Node<T> node)
        {
            if (AdjacencyList.Find(vertex => vertex.Value.Equals(node.Value)) != null)
            {
                throw new ArgumentException("This vertex is already in this graph!");
            }

            AdjacencyList.Add(node);
            foreach(Node<T> child in node.Children)
            {
                Node<T> matchingNode = AdjacencyList.Find(vertex => vertex.Value.Equals(child.Value));
                if (matchingNode != null) matchingNode.Children.Add(node);
                else
                {
                    if (!child.Children.Contains(node)) child.Children.Add(node);
                    AdjacencyList.Add(child);
                }
            }
        }

        /// <summary>
        /// Gets a list of all of the nodes in the Graph.
        /// </summary>
        /// <returns>A list of nodes.</returns>
        public List<Node<T>> GetNodes()
        {
            return AdjacencyList;
        }

        /// <summary>
        /// Gets a list of all nodes neighboring a specified node.
        /// </summary>
        /// <param name="node">The node being checked.</param>
        /// <returns>A list of nodes.</returns>
        public List<Node<T>> GetNeighbors(Node<T> node)
        {
            return node.Children;
        }

        /// <summary>
        /// Gets the number of nodes in the Graph.
        /// </summary>
        /// <returns>An integer representing the number of nodes in the Graph.</returns>
        public int Size()
        {
            return AdjacencyList.Count;
        }

        /// <summary>
        /// Conducts a Breadth-First traversal of the Graph.
        /// </summary>
        /// <param name="root">The starting node for the traversal.</param>
        /// <returns>A list of nodes.</returns>
        public List<Node<T>> BreadthFirst(Node<T> root)
        {
            foreach (Node<T> node in AdjacencyList)
            {
                node.Visited = false;
            }

            List<Node<T>> order = new List<Node<T>>();
            Queue<Node<T>> breadth = new Queue<Node<T>>();
            breadth.Enqueue(root);

            while (breadth.TryDequeue(out root))
            {
                order.Add(root);
                root.Visited = true;

                foreach(Node<T> child in root.Children)
                {
                    if (!child.Visited)
                    {
                        breadth.Enqueue(child);
                    }
                }
            }

            return order;
        }
    }
}
