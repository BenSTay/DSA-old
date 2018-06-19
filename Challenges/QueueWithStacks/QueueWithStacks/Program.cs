using System;
using Stack_and_Queue.Classes;
using QueueWithStacks.Classes;

namespace QueueWithStacks
{
    class Program
    {
        /// <summary>
        /// Creates and populates a SQueue.
        /// </summary>
        /// <param name="start">The value of the first node in the SQueue.</param>
        /// <param name="end">The maximum value for the nodes generated.</param>
        /// <param name="step">The difference in the values of adjacent nodes.</param>
        /// <returns>The resulting SQueue.</returns>
        static SQueue MakeQueue(int start, int end, int step)
        {
            Node node = new Node(start);
            SQueue queue = new SQueue(node);
            for (int i = start + step; i <= end; i += step)
            {
                node = new Node(i);
                queue.Enqueue(node);
            }
            return queue;
        }

        /// <summary>
        /// Displays the SQueue in the console.
        /// </summary>
        /// <param name="queue">The SQueue being displayed.</param>
        static void ViewQueue(SQueue queue)
        {
            Node node = queue.Peek();
            Console.Write("FRONT --> ");
            while (node != null)
            {
                Console.Write($"{node.Value} --> ");
                node = node.Next;
            }
            Console.Write("NULL\n");
        }

        static void Main(string[] args)
        {
            SQueue queue = MakeQueue(5, 50, 5);
            Console.WriteLine("Initial queue");
            ViewQueue(queue);
            queue.Enqueue(queue.Dequeue());
            Console.WriteLine("\nQueue after moving the front to the rear");
            ViewQueue(queue);
            Console.ReadKey();
        }
    }
}
