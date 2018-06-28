using System;
using System.Collections.Generic;
using System.Text;
using Trees.Classes;

namespace FizzBuzzTree
{
    public class Program
    {
        /// <summary>
        /// Changes nodes values to Fizz if divisible by 3, to Buzz if divisible by 5, or FizzBuzz if divisible by both.
        /// </summary>
        /// <param name="tree">The tree being modified</param>
        /// <returns>The modified tree</returns>
        public static Tree<string> FizzBuzzTree(Tree<string> tree)
        {
            Queue<Node<string>> breadth = new Queue<Node<string>>();
            breadth.Enqueue(tree.Root);

            while (breadth.TryDequeue(out Node<string> node))
            {
                if (node.LeftChild != null) breadth.Enqueue(node.LeftChild);
                if (node.RightChild != null) breadth.Enqueue(node.RightChild);

                if (Int32.TryParse(node.Value, out int value))
                {
                    StringBuilder fizzBuzz = new StringBuilder();
                    if (value != 0)
                    {
                        if (value % 3 == 0) fizzBuzz.Append("Fizz");
                        if (value % 5 == 0) fizzBuzz.Append("Buzz");
                    }
                    if (fizzBuzz.ToString().Contains('z'))
                    {
                        node.Value = fizzBuzz.ToString();
                    }
                }
            }
            return tree;
        }

        /// <summary>
        /// Makes a binary tree with 16 nodes of ascending value.
        /// </summary>
        /// <returns>A binary tree</returns>
        public static Tree<string> BuildTree()
        {
            BinaryTree<string> tree = new BinaryTree<string>(new Node<string>("0"));

            for (int i = 1; i < 16; i++)
            {
                tree.Add(new Node<string>($"{i}"));
            }

            return tree;
        }

        static void Main(string[] args)
        {
            Tree<string> tree = BuildTree();
            FizzBuzzTree(tree);
            tree.BreadthFirst();
            Console.ReadKey();
        }
    }
}
