using System;
using Xunit;
using Trees;
using Trees.Classes;

namespace TestTrees
{
    public class UnitTest1
    {
        [Fact]
        public void TestBSTSearch()
        {
            BinarySearchTree tree = Program.MakeBST();
            Assert.IsType<Node>(tree.Search(6));
        }

        [Fact]
        public void TestBSTAdd()
        {
            BinarySearchTree tree = Program.MakeBST();
            tree.Add(new Node(-5));
            Assert.IsType<Node>(tree.Search(-5));
        }

        [Fact]
        public void TestBTSearch()
        {
            BinaryTree tree = Program.MakeBT();
            Assert.IsType<Node>(tree.Search(6));
        }
    }
}
