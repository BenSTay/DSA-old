using System;
using Xunit;
using Trees.Classes;
using FindMaximumValueBinaryTree;

namespace MaxValueTest
{
    public class UnitTest1
    {
        [Fact]
        public void TestMaxValueBT()
        {
            BinaryTree<int> tree = new BinaryTree<int>(new Node<int>(50));
            Program.FillTree(tree);
            Assert.Equal(94, Program.FindMax(tree));
        }

        [Fact]
        public void TestMaxValueBST()
        {
            BinarySearchTree<int> tree = new BinarySearchTree<int>(new Node<int>(50));
            Program.FillTree(tree);
            Assert.Equal(94, Program.FindMax(tree));
        }

        [Fact]
        public void TestMaxValueAtRoot()
        {
            BinaryTree<int> tree = new BinaryTree<int>(new Node<int>(999999));
            Program.FillTree(tree);
            Assert.Equal(999999, Program.FindMax(tree));
        }
    }
}
