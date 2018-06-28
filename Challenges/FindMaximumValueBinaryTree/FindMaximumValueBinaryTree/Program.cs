using System;
using System.Collections.Generic;
using Trees.Classes;

namespace FindMaximumValueBinaryTree
{
    public class Program
    {
        /// <summary>
        /// Finds the maximum integer value in a binary tree of integers.
        /// </summary>
        /// <param name="tree">The tree being searched.</param>
        /// <returns>The maximum value.</returns>
        public static int FindMax(Tree<int> tree)
        {
            Queue<Node<int>> breadth = new Queue<Node<int>>();
            breadth.Enqueue(tree.Root);
            int max = tree.Root.Value;

            while (breadth.TryDequeue(out Node<int> front))
            {
                if (front.LeftChild != null) breadth.Enqueue(front.LeftChild);
                if (front.RightChild != null) breadth.Enqueue(front.RightChild);
                if (front.Value > max) max = front.Value;
            }

            return max;
        }

        /// <summary>
        /// Adds nodes to an existing tree.
        /// </summary>
        /// <param name="tree">The tree being added to.</param>
        public static void FillTree(Tree<int> tree)
        {
            tree.Add(new Node<int>(25));
            tree.Add(new Node<int>(12));
            tree.Add(new Node<int>(6));
            tree.Add(new Node<int>(18));
            tree.Add(new Node<int>(38));
            tree.Add(new Node<int>(75));
            tree.Add(new Node<int>(88));
            tree.Add(new Node<int>(94));
            tree.Add(new Node<int>(82));
            tree.Add(new Node<int>(62));
        }

        static void Main(string[] args)
        {
            Random rand = new Random();
            BinaryTree<int> tree = new BinaryTree<int>(new Node<int>(500));
            for (int i = 0; i < 10; i++)
            {
                while (true)
                {
                    try
                    {
                        tree.Add(new Node<int>(rand.Next(1000)));
                        break;
                    }
                    catch { continue; }
                }

            }
            Console.WriteLine("Tree values:");
            tree.InOrder();
            Console.WriteLine("\nMax value:");
            Console.WriteLine(FindMax(tree));
            Console.ReadKey();
        }
    }
}
