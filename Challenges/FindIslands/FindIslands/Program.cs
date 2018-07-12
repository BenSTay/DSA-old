using System;
using Graphs.Classes;

namespace FindIslands
{
    public class Program
    {
        /// <summary>
        /// Counts the number of islands in a graph using its adjacency matrix.
        /// </summary>
        /// <param name="matrix">An adjacency matrix for a graph.</param>
        /// <returns>The number of islands in the graph, or -1 if the graph is empty.</returns>
        public static int FindIslands(bool[,] matrix)
        {
            bool[] visited = new bool[matrix.GetLength(0)];
            int count = -1;
            for (int i = 0; i < visited.Length; i++)
            {
                if (!visited[i])
                {
                    count++;
                    visited[i] = true;
                    CheckNeighbors(matrix, i, visited);
                }
            }
            return count;
        }

        /// <summary>
        /// A helper method for FindIslands (Shouldn't be used by itself).
        /// Marks each of a node's neighbors (and its neighbors neighbors, and so on) as visited.
        /// </summary>
        /// <param name="matrix">The adjacency matrix for a graph.</param>
        /// <param name="index">The index to start searching for neighbors.</param>
        /// <param name="visited">An array of booleans representing whether the node has been visited or not.</param>
        public static void CheckNeighbors(bool[,] matrix, int index, bool[] visited)
        {
            for (int i = index + 1; i < visited.Length; i++)
            {
                if (matrix[index, i] && !visited[i])
                {
                    visited[i] = true;
                    CheckNeighbors(matrix, i, visited);
                }
            }
        }

        static void Main(string[] args)
        {
            Graph<string> graph = new Graph<string>();

            Node<string> a = new Node<string>("A");
            graph.AddEdge(a);

            Node<string> b = new Node<string>("B");
            graph.AddEdge(b);

            Node<string> c = new Node<string>("C");
            c.Neighbors.Add(new Edge<string>(b));
            graph.AddEdge(c);

            Node<string> d = new Node<string>("D");
            d.Neighbors.Add(new Edge<string>(a));
            graph.AddEdge(d);

            Node<string> e = new Node<string>("E");
            e.Neighbors.Add(new Edge<string>(b));
            e.Neighbors.Add(new Edge<string>(c));
            graph.AddEdge(e);

            foreach(Node<string> node in graph.BreadthFirst(a))
            {
                Console.Write(node.Value);
            }

            Console.WriteLine();

            foreach(Node<string> node in graph.BreadthFirst(b))
            {
                Console.Write(node.Value);
            }

            Console.WriteLine($"\nIslands: {FindIslands(graph.GetMatrix())}");

            Console.ReadKey();
        }
    }
}
