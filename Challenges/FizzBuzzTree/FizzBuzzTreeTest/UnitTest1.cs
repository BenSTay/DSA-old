using System;
using Xunit;
using FizzBuzzTree;
using Trees.Classes;

namespace FizzBuzzTreeTest
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("3", "Fizz")]
        [InlineData("5", "Buzz")]
        [InlineData("30", "FizzBuzz")]
        [InlineData("17", "17")]
        [InlineData(null, null)]
        [InlineData("Dog", "Dog")]
        [InlineData("-5", "Buzz")]
        [InlineData("15.5", "15.5")]
        public void TestFizzBuzz(string value, string expected)
        {
            BinaryTree<string> tree = new BinaryTree<string>(new Node<string>(value));
            Program.FizzBuzzTree(tree);
            Assert.Equal(expected, tree.Root.Value);
        }

        [Fact]
        public void TestFizzBuzzTree()
        {
            Tree<string> tree = Program.BuildTree();
            Program.FizzBuzzTree(tree);
            Assert.NotNull(tree.Search("Fizz"));
        }
    }
}
