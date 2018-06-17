using System;
using Stack_and_Queue.Classes;

namespace Stack_and_Queue
{
    class Program
    {
        /// <summary>
        /// Populates a stack with 9 nodes.
        /// </summary>
        /// <param name="stack">The stack being populated.</param>
        static void MakeStack(Stack stack)
        {
            for (int i = 1; i < 10; i++)
            {
                stack.Push(new Node(i));
            }
        }

        /// <summary>
        /// Populates a queue with 9 nodes.
        /// </summary>
        /// <param name="queue">The queue being populated.</param>
        static void MakeQueue(Queue queue)
        {
            for (int i = 1; i < 10; i++)
            {
                queue.Enqueue(new Node(i));
            }
        }

        /// <summary>
        /// Displays all of the nodes in a stack.
        /// </summary>
        /// <param name="stack">The stack being viewed.</param>
        static void ViewStack(Stack stack)
        {
            Node node = stack.Peek();
            Console.Write("TOP -> ");
            while (node != null)
            {
                Console.Write($"{node.Value} -> ");
                node = node.Next;
            }
            Console.Write("NULL\n");
        }

        /// <summary>
        /// Displays all of the nodes in a queue.
        /// </summary>
        /// <param name="queue">The queue being viewed.</param>
        static void ViewQueue(Queue queue)
        {
            Node node = queue.Peek();
            Console.Write("FRONT -> ");
            while (node.Next != null)
            {
                Console.Write($"{node.Value} -> ");
                node = node.Next;
            }
            Console.Write($"{node.Value} <- REAR\n");
        }

        static void Main(string[] args)
        {
            Stack stack = new Stack(new Node(0));
            Queue queue = new Queue(new Node(0));
            MakeStack(stack);
            ViewStack(stack);
            MakeQueue(queue);
            ViewQueue(queue);
            Console.ReadKey();
        }
    }
}
