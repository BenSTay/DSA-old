using System;
using Xunit;
using Graphs.Classes;

namespace GraphTests
{
    public class UnitTest1
    {
        [Fact]
        public void TestSize()
        {
            Graph<string> graph = new Graph<string>(new Node<string>("A"));
            Assert.Equal(1, graph.Size());
        }

        [Fact]
        public void TestGetNeighbors()
        {
            Node<string> node = new Node<string>("A");
            node.Children.Add(new Node<string>("B"));
            Graph<string> graph = new Graph<string>(node);
            Assert.Equal(node.Children, graph.GetNeighbors(node));
        }

        [Fact]
        public void TestAddEdge()
        {
            Graph<string> graph = new Graph<string>(new Node<string>("A"));
            graph.AddEdge(new Node<string>("B"));
            Assert.Equal(2, graph.Size());
        }
    }
}
