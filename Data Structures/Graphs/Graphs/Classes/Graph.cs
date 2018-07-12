using System;
using System.Collections.Generic;
using System.Text;

namespace Graphs.Classes
{
    public class Graph<T>
    {
        protected List<Node<T>> Vertices { get; set; }

        /// <summary>
        /// Creates a new instance of the Graph class.
        /// </summary>
        /// <param name="node">The first node in the Graph.</param>
        public Graph()
        {
            Vertices = new List<Node<T>>();
        }

        /// <summary>
        /// Adds a node to the Graph.
        /// </summary>
        /// <param name="node">The node being added.</param>
        public void AddEdge(Node<T> node)
        {
            if (Vertices.Find(vertex => vertex.Value.Equals(node.Value)) != null)
            {
                throw new ArgumentException("This vertex is already in this graph!");
            }

            Vertices.Add(node);
            foreach(Edge<T> edge in node.Neighbors)
            {
                //Finds the node in the graph with a value that matches the edges node, if any.
                Node<T> matchingNode = Vertices.Find(vertex => vertex.Value.Equals(edge.Node.Value));

                //If a matching node is found, the new node is added to its list of neighbors.
                if (matchingNode != null) matchingNode.Neighbors.Add(new Edge<T>(node, edge.Weight));
            }
        }

        /// <summary>
        /// Gets a list of all of the nodes in the Graph.
        /// </summary>
        /// <returns>A list of nodes.</returns>
        public List<Node<T>> GetNodes()
        {
            return Vertices;
        }

        /// <summary>
        /// Gets a list of all nodes neighboring a specified node.
        /// </summary>
        /// <param name="node">The node being checked.</param>
        /// <returns>A list of nodes.</returns>
        public List<Node<T>> GetNeighbors(Node<T> node)
        {
            List<Node<T>> neighbors = new List<Node<T>>();
            foreach (Edge<T> edge in node.Neighbors)
            {
                neighbors.Add(edge.Node);
            }
            return neighbors;
        }

        /// <summary>
        /// Gets the number of nodes in the Graph.
        /// </summary>
        /// <returns>An integer representing the number of nodes in the Graph.</returns>
        public int Size()
        {
            return Vertices.Count;
        }

        /// <summary>
        /// Conducts a Breadth-First traversal of the Graph.
        /// </summary>
        /// <param name="root">The starting node for the traversal.</param>
        /// <returns>A list of nodes.</returns>
        public List<Node<T>> BreadthFirst(Node<T> root)
        {
            foreach (Node<T> node in Vertices)
            {
                node.Visited = false;
            }

            List<Node<T>> order = new List<Node<T>>();
            Queue<Node<T>> breadth = new Queue<Node<T>>();
            breadth.Enqueue(root);
            root.Visited = true;

            while (breadth.TryDequeue(out root))
            {
                order.Add(root);

                foreach(Edge<T> edge in root.Neighbors)
                {
                    if (!edge.Node.Visited)
                    {
                        edge.Node.Visited = true;
                        breadth.Enqueue(edge.Node);
                    }
                }
            }

            return order;
        }

        public bool[,] GetMatrix()
        {
            int count = Vertices.Count;
            bool[,] matrix = new bool[count, count];
            for (int i = 0; i < count; i++)
            {
                foreach (Node<T> neighbor in GetNeighbors(Vertices[i]))
                {
                    int j = Vertices.IndexOf(neighbor);
                    matrix[i, j] = true;
                }
            }
            return matrix;
        }
    }
}
