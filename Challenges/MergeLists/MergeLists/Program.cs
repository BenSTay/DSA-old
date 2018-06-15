using LinkedLists.Classes;
using System;

namespace MergeLists
{
    public class Program
    {
        public static Node MergeLists(LinkedList list1, LinkedList list2)
        {
            Node temp;
            list1.Current = list1.Head;
            while (list1.Current.Next != null && list2.Head != null)
            {
                temp = list2.Head;
                list2.Head = list2.Head.Next;
                temp.Next = list1.Current.Next;
                list1.Current.Next = temp;
                list1.Current = list1.Current.Next.Next;
            }
            if (list2.Head != null)
            {
                list1.Current.Next = list2.Head;
            }
            return list1.Head;
        }

        static void TestMerge()
        {
            LinkedList list1 = new LinkedList(new Node(0));
            LinkedList list2 = new LinkedList(new Node(1));
            list1.AddLast(new Node(2));
            list2.AddLast(new Node(3));
            list1.AddLast(new Node(4));
            list2.AddLast(new Node(5));
            Console.WriteLine("Input:");
            list1.Print();
            list2.Print();
            list2.Head = MergeLists(list1, list2);
            Console.WriteLine("\nOutput:");
            list2.Print();
        }
        static void Main(string[] args)
        {
            TestMerge();
            Console.ReadKey();
        }
    }
}
