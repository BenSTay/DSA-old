using System;

namespace InsertionSort
{
    public class Program
    {
        /// <summary>
        /// Sorts an array of integers.
        /// </summary>
        /// <param name="array">The array being sorted.</param>
        /// <returns>The sorted array.</returns>
        public static int[] InsertionSort(int[] array)
        {
            int length = array.Length;
            int[] sorted = new int[length];
            sorted[0] = array[0];

            int current, previous;
            for (int i = 1; i < length; i++)
            {
                current = array[i];
                sorted[i] = current;

                for (int j = i - 1; j >= 0; j--)
                {
                    previous = sorted[j];
                    if (current < previous)
                    {
                        sorted[j] = current;
                        sorted[j + 1] = previous;
                    }
                    else break;
                }
            }
            return sorted;
        }

        /// <summary>
        /// Generates a random array.
        /// </summary>
        /// <param name="length">The length of the array.</param>
        /// <param name="min">The minimum value of each int in the array</param>
        /// <param name="max">The maximum value of each int in the array</param>
        /// <returns>A array of integers.</returns>
        public static int[] RandomArray(int length, int min, int max)
        {
            Random rand = new Random();
            int[] array = new int[length];
            for (int i = 0; i < length; i++)
            {
                array[i] = rand.Next(min, max);
            }
            return array;
        }

        /// <summary>
        /// Writes the contents of an array to the console window.
        /// </summary>
        /// <param name="array">The array to be displayed.</param>
        static void DisplayArray(int[] array)
        {
            Console.Write($"[{array[0]}");
            for (int i = 1; i < array.Length; i++)
            {
                Console.Write($", {array[i]}");
            }
            Console.WriteLine("]");
        }

        static void Main(string[] args)
        {
            int[] array = new int[] {27, 4, 18, 10, 36, 4, 10, 10, 23, 25, 5 , 2, 15, 47, 25};
            Console.Write("Input Array: ");
            DisplayArray(array);
            Console.Write("Output Array: ");
            DisplayArray(InsertionSort(array));

            Console.WriteLine();

            int[] random = RandomArray(15, 1, 50);
            Console.Write("Input Array: ");
            DisplayArray(random);
            Console.Write("Output Array: ");
            DisplayArray(InsertionSort(random));

            Console.ReadKey();
        }
    }
}
