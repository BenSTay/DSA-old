using System;
using Trees.Classes;

namespace Trees
{
    public class Program
    {



        static void Main(string[] args)
        {
            BinarySearchTree<int> searchTree = new BinarySearchTree<int>(new Node<int>(0));
            searchTree.BreadthFirst();
            Console.ReadKey();
        }
    }
}
