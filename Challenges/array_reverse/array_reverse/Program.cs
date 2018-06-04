using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reverse_array
{
    class Program
    {
        static int[] ReverseArray(int[] array)
        {
            int[] newArray = new int[array.Length];
            for (int i = 1; i <= array.Length; i++)
            {
                newArray[i - 1] = array[array.Length - i];
            }
            return newArray;
        }

        static void Main(string[] args)
        {
            int[] testarray = new int[] { 1, 2, 3, 4, 5, 6 };
            int[] result = ReverseArray(testarray);
            foreach (int item in result)
            {
                Console.Write($"{item}, ");
            }
            Console.ReadLine();
        }
    }
}
