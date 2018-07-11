using System;
using Xunit;
using Graphs.Classes;
using System.Collections.Generic;

namespace GraphTests
{
    public class UnitTest1
    {
        [Fact]
        public void TestSize()
        {
            Graph<string> graph = new Graph<string>();
            graph.AddEdge(new Node<string>("A"));
            Assert.Equal(1, graph.Size());
        }

        [Fact]
        public void TestGetNeighbors()
        {
            Node<string> node = new Node<string>("A");
            node.Neighbors.Add(new Edge<string>(new Node<string>("B")));
            Graph<string> graph = new Graph<string>();
            graph.AddEdge(node);
            List<Node<string>> nodes = new List<Node<string>>();
            foreach (Edge<string> edge in node.Neighbors)
            {
                nodes.Add(edge.Node);
            }
            
            Assert.Equal(nodes, graph.GetNeighbors(node));
        }

        [Fact]
        public void TestAddEdge()
        {
            Graph<string> graph = new Graph<string>();
            graph.AddEdge(new Node<string>("A"));
            graph.AddEdge(new Node<string>("B"));
            Assert.Equal(2, graph.Size());
        }
    }
}
