using LinkedLists.Classes;
using System;

namespace LinkedLists
{
    class Program
    {
        static void Main(string[] args)
        {
            Node node = new Node(0);
            LinkedList list = new LinkedList(node);
            for (int i = 1; i < 10; i++)
            {
                list.Add(new Node(i));
            }
            list.AddBefore(new Node(50), list.Find(3));
            list.AddAfter(new Node(999), list.Find(50));
            list.Print();
            Console.ReadKey();
        }
    }
}
