using System;
using Graphs.Classes;

namespace Graphs
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creates a graph
            Graph<string> graph = new Graph<string>();
            graph.AddEdge(new Node<string>("A"));

            //Prepares nodes to be added to the graph
            Node<string> node2 = new Node<string>("B");
            node2.Neighbors.Add(new Edge<string>(new Node<string>("C")));
            node2.Neighbors.Add(new Edge<string>(graph.GetNodes()[0]));

            //Adds the new nodes to the graph
            graph.AddEdge(node2.Neighbors[0].Node);
            graph.AddEdge(node2);
            

            //Displays the number of nodes in the graph, and then displays the graph as
            //an adjacency list.
            Console.WriteLine($"Nodes in graph: {graph.Size()}");
            foreach (Node<string> node in graph.GetNodes())
            {
                Console.Write(node.Value);
                foreach (Node<string> child in graph.GetNeighbors(node))
                {
                    Console.Write($" -> {child.Value}");
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            //Conducts a breadth-first traversal starting at the node with the value "B"
            //and displays the result in the console.
            foreach (Node<string> node in graph.BreadthFirst(node2))
            {
                Console.Write(node.Value);
            }

            graph.GetMatrix();

            Console.ReadKey();
        }
    }
}
