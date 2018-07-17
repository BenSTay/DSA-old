using System;
using Trees.Classes;
using Hashtables.Classes;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace TreeIntersection
{
    public class Program
    {
        /// <summary>
        /// Finds all matching values in two binary trees.
        /// </summary>
        /// <param name="tree1">The first tree being compared.</param>
        /// <param name="tree2">The second tree being compared.</param>
        /// <returns>A list of matching values.</returns>
        public static List<string> TreeIntersection(Tree<string> tree1, Tree<string> tree2)
        {
            Hashtable<int> hashtable = new Hashtable<int>();
            List<string> intersections = new List<string>();
            Queue<Node<string>> breadth = new Queue<Node<string>>();
            breadth.Enqueue(tree1.Root);

            while (breadth.TryDequeue(out Node<string> node))
            {
                if (node.LeftChild != null) breadth.Enqueue(node.LeftChild);
                if (node.RightChild != null) breadth.Enqueue(node.RightChild);

                if (!hashtable.Contains(node.Value)) hashtable.Add(node.Value, 0);
            }

            breadth.Enqueue(tree2.Root);
            while (breadth.TryDequeue(out Node<string> node))
            {
                if (node.LeftChild != null) breadth.Enqueue(node.LeftChild);
                if (node.RightChild != null) breadth.Enqueue(node.RightChild);

                if (hashtable.Contains(node.Value) && !intersections.Contains(node.Value))
                {
                    intersections.Add(node.Value);
                }
            }

            return intersections;
        }

        /// <summary>
        /// Creates a binary tree using an array of values.
        /// </summary>
        /// <param name="values">The values used to build the tree.</param>
        /// <returns>A binary tree.</returns>
        public static Tree<string> GenerateTree(string[] values)
        {
            Tree<string> tree = new BinaryTree<string>(new Node<string>(values[0]));
            foreach(string value in values)
            {
                tree.Add(new Node<string>(value));
            }
            return tree;
        }

        static void Main(string[] args)
        {
            string string1 = "The quick brown fox jumps over the lazy dog";
            string string2 = "What does the fox say";

            string[] string1Words = Regex.Split(string1.ToLower(), @"\W+");
            string[] string2Words = Regex.Split(string2.ToLower(), @"\W+");

            Tree<string> tree1 = GenerateTree(string1Words);
            Tree<string> tree2 = GenerateTree(string2Words);

            List<string> matches = TreeIntersection(tree1, tree2);

            Console.WriteLine($"Tree 1 words: {string1}");
            Console.WriteLine($"Tree 2 words: {string2}");
            Console.Write("Matching words:");
            foreach (string word in matches)
            {
                Console.Write($" {word}");
            }
            Console.ReadKey();
        }
    }
}
