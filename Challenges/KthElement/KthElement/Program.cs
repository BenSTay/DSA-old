using LinkedLists.Classes;
using System;

namespace KthElement
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList(new Node(2));
            list.Add(new Node(8));
            list.Add(new Node(3));
            list.Add(new Node(1));
            Console.Write("Input: ");
            list.Print();
            // Change this line to test different numbers!
            int k = 2;
            Console.WriteLine($"Args: {k}");
            Console.Write("Output: ");
            try
            {
                Console.Write(list.KthElement(k).Value);
            } catch (IndexOutOfRangeException ex)
            {
                Console.Write(ex.Message);
            }
            Console.ReadKey();
            }
    }
}
