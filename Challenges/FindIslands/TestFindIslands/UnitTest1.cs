using System;
using Xunit;
using Graphs.Classes;
using FindIslands;

namespace TestFindIslands
{
    public class UnitTest1
    {
        [Fact]
        public void TestNoNeighbors()
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

            Node<string> f = new Node<string>("F");
            graph.AddEdge(f);

            bool[,] matrix = graph.GetMatrix();
            int index = graph.GetNodes().IndexOf(f);
            bool[] visited = new bool[graph.Size()];
            visited[index] = true;
            Program.CheckNeighbors(matrix, index, visited);

            int count = 0;
            for (int i = 0; i < visited.Length; i++)
            {
                if (visited[i] && i != index) count++;
            }

            Assert.Equal(0, count);
        }

        [Fact]
        public void TestHasNeighbors()
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

            Node<string> f = new Node<string>("F");
            graph.AddEdge(f);

            bool[,] matrix = graph.GetMatrix();
            int index = graph.GetNodes().IndexOf(b);
            bool[] visited = new bool[graph.Size()];
            visited[index] = true;
            Program.CheckNeighbors(matrix, index, visited);

            int count = 0;
            for (int i = 0; i < visited.Length; i++)
            {
                if (visited[i] && i != index) count++;
            }

            Assert.Equal(2, count);
        }

        [Fact]
        public void TestAllNeighbors()
        {
            Graph<string> graph = new Graph<string>();

            Node<string> a = new Node<string>("A");
            graph.AddEdge(a);

            Node<string> b = new Node<string>("B");
            b.Neighbors.Add(new Edge<string>(a));
            graph.AddEdge(b);

            Node<string> c = new Node<string>("C");
            c.Neighbors.Add(new Edge<string>(a));
            c.Neighbors.Add(new Edge<string>(b));
            graph.AddEdge(c);

            Node<string> d = new Node<string>("D");
            d.Neighbors.Add(new Edge<string>(a));
            d.Neighbors.Add(new Edge<string>(c));
            graph.AddEdge(d);

            Node<string> e = new Node<string>("E");
            e.Neighbors.Add(new Edge<string>(b));
            e.Neighbors.Add(new Edge<string>(c));
            e.Neighbors.Add(new Edge<string>(d));
            graph.AddEdge(e);

            bool[,] matrix = graph.GetMatrix();
            int index = graph.GetNodes().IndexOf(a);
            bool[] visited = new bool[graph.Size()];
            visited[index] = true;
            Program.CheckNeighbors(matrix, index, visited);

            int count = 0;
            for (int i = 0; i < visited.Length; i++)
            {
                if (visited[i] && i != index) count++;
            }

            Assert.Equal(graph.Size() - 1, count);
        }

        [Fact]
        public void TestNoIslands()
        {
            Graph<string> graph = new Graph<string>();

            Node<string> a = new Node<string>("A");
            graph.AddEdge(a);

            Node<string> b = new Node<string>("B");
            b.Neighbors.Add(new Edge<string>(a));
            graph.AddEdge(b);

            Node<string> c = new Node<string>("C");
            c.Neighbors.Add(new Edge<string>(a));
            c.Neighbors.Add(new Edge<string>(b));
            graph.AddEdge(c);

            Node<string> d = new Node<string>("D");
            d.Neighbors.Add(new Edge<string>(a));
            d.Neighbors.Add(new Edge<string>(c));
            graph.AddEdge(d);

            Node<string> e = new Node<string>("E");
            e.Neighbors.Add(new Edge<string>(b));
            e.Neighbors.Add(new Edge<string>(c));
            e.Neighbors.Add(new Edge<string>(d));
            graph.AddEdge(e);

            bool[,] matrix = graph.GetMatrix();
            Assert.Equal(0, Program.FindIslands(matrix));
        }

        [Fact]
        public void TestHasIslands()
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

            Node<string> f = new Node<string>("F");
            graph.AddEdge(f);

            bool[,] matrix = graph.GetMatrix();
            Assert.Equal(2, Program.FindIslands(matrix));
        }

        [Fact]
        public void TestEmptyGraph()
        {
            Graph<string> graph = new Graph<string>();
            bool[,] matrix = graph.GetMatrix();
            Assert.Equal(-1, Program.FindIslands(matrix));
        }
    }
}
