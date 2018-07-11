using System;
using System.Collections.Generic;
using Graphs.Classes;

namespace GetEdge
{
    public class Program
    {
        /// <summary>
        /// Constructs a graph with six nodes, for use in testing the GetEdge method.
        /// </summary>
        /// <returns>A graph containing route information for six locations.</returns>
        public static Graph<string> MakeGraph()
        {
            Graph<string> graph = new Graph<string>();
            Node<string> Pandora = new Node<string>("Pandora");
            Node<string> Arendelle = new Node<string>("Arendelle");
            Node<string> Metroville = new Node<string>("Metroville");
            Node<string> Monstropolis = new Node<string>("Monstropolis");
            Node<string> Narnia = new Node<string>("Narnia");
            Node<string> Naboo = new Node<string>("Naboo");

            graph.AddEdge(Pandora);
            graph.AddEdge(Monstropolis);
            graph.AddEdge(Narnia);

            Arendelle.Neighbors.Add(new Edge<string>(Pandora, 150));
            Arendelle.Neighbors.Add(new Edge<string>(Monstropolis, 42));
            graph.AddEdge(Arendelle);

            Naboo.Neighbors.Add(new Edge<string>(Monstropolis, 73));
            Naboo.Neighbors.Add(new Edge<string>(Narnia, 250));
            graph.AddEdge(Naboo);

            Metroville.Neighbors.Add(new Edge<string>(Pandora, 82));
            Metroville.Neighbors.Add(new Edge<string>(Arendelle, 99));
            Metroville.Neighbors.Add(new Edge<string>(Monstropolis, 105));
            Metroville.Neighbors.Add(new Edge<string>(Naboo, 26));
            Metroville.Neighbors.Add(new Edge<string>(Narnia, 37));
            graph.AddEdge(Metroville);

            return graph;
        }

        /// <summary>
        /// Determines if a route is possible, and if calculates the price of that route if it is.
        /// </summary>
        /// <param name="graph">The graph describing the possible routes and prices.</param>
        /// <param name="locations">An array of desired travel locations.</param>
        /// <returns>A boolean representing if the route is possible, and an integer representing the total price of the route.</returns>
        public static (bool, int) GetEdge(Graph<string> graph, string[] locations)
        {
            Node<string> current = graph.GetNodes().Find(node => node.Value == locations[0]);
            if (current == null) return (false, 0);

            int totalCost = 0;
            for (int i = 1; i < locations.Length; i++)
            {
                Edge<string> destination = current.Neighbors.Find(edge => edge.Node.Value == locations[i]);
                if (destination == null) return (false, 0);
                else
                {
                    totalCost += destination.Weight;
                    current = destination.Node;
                }
            }
            return (true, totalCost);
        }

        static void Main(string[] args)
        {
            Graph<string> graph = MakeGraph();
            string[] locations = new string[] { "Arendelle", "Monstropolis", "Naboo" };
            var result = GetEdge(graph, locations);

            Console.Write($"Route: {locations[0]}");
            for (int i = 1; i < locations.Length; i++)
            {
                Console.Write($" -> {locations[i]}");
            }

            Console.WriteLine($"\nResult: {result.Item1}, Price: ${result.Item2}");
            Console.ReadKey();
        }
    }
}
