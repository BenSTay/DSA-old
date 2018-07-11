using System;
using Xunit;
using Graphs.Classes;
using GetEdge;

namespace TestGetEdge
{
    public class UnitTest1
    {
        [Fact]
        public void TestMakeGraphSize()
        {
            Graph<string> graph = Program.MakeGraph();
            Assert.Equal(6, graph.Size());
        }

        [Fact]
        public void TestMakeGraphNeighbors()
        {
            Graph<string> graph = Program.MakeGraph();
            Assert.NotNull(graph.GetNeighbors(graph.GetNodes()[0]).Find(node => node.Value == "Arendelle"));
        }

        [Fact]
        public void TestMakeGraphHasNarnia()
        {
            Graph<string> graph = Program.MakeGraph();
            Assert.Throws<ArgumentException>(() => graph.AddEdge(new Node<string>("Narnia")));
        }

        [Fact]
        public void TestPossibleRoute()
        {
            Graph<string> graph = Program.MakeGraph();
            string[] locations = new string[] { "Metroville", "Pandora" };
            var result = Program.GetEdge(graph, locations);
            Assert.True(result.Item1);
            Assert.Equal(82, result.Item2);
        }

        [Fact]
        public void TestImpossibleRoute()
        {
            Graph<string> graph = Program.MakeGraph();
            string[] locations = new string[] { "Narnia", "Arendelle", "Naboo" };
            var result = Program.GetEdge(graph, locations);
            Assert.False(result.Item1);
            Assert.Equal(0, result.Item2);
        }

        [Fact]
        public void TestLocationDoesNotExist()
        {
            Graph<string> graph = Program.MakeGraph();
            string[] locations = new string[] { "Metroville", "Pandora", "Seattle" };
            var result = Program.GetEdge(graph, locations);
            Assert.False(result.Item1);
            Assert.Equal(0, result.Item2);
        }
    }
}
