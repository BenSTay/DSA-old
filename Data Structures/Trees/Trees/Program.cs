using System;
using Trees.Classes;

namespace Trees
{
    public class Program
    {
        static void AddNodes(Tree tree)
        {
            tree.Add(new Node(1));
            tree.Add(new Node(0));
            tree.Add(new Node(3));
            tree.Add(new Node(2));
            tree.Add(new Node(4));
            tree.Add(new Node(7));
            tree.Add(new Node(6));
            tree.Add(new Node(8));
            tree.Add(new Node(9));
        }

        public static BinarySearchTree MakeBST()
        {
            BinarySearchTree tree = new BinarySearchTree(new Node(5));
            AddNodes(tree);
            return tree;
        }

        public static BinaryTree MakeBT()
        {
            BinaryTree tree = new BinaryTree(new Node(5));
            AddNodes(tree);
            return tree;
        }


        static void Main(string[] args)
        {
            BinarySearchTree searchTree = MakeBST();
            BinaryTree tree = MakeBT();
            // Actual order should be 0123456789
            Console.WriteLine("Binary Search Tree (InOrder)");
            searchTree.InOrder();
            // Actual order should be 6381925407
            Console.WriteLine("\n\nBinary Tree (InOrder)");
            tree.InOrder();
            Console.ReadLine();
        }
    }
}
