using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    class Program
    {
        static string StringifyArray(int[] array)
        {
            int lastIndex = array.Length - 1;
            StringBuilder arrayString = new StringBuilder("[ ");
            for (int i = 0; i < lastIndex; i++ )
            {
                arrayString.Append($"{ array[i] }, ");
            }
            arrayString.Append($"{ array[lastIndex]} ]");
            return arrayString.ToString();
        }

        static int BinarySearch(int[] array, int key)
        {
            int start = 0;
            int end = array.Length - 1;
            int mid;
            while (start <= end)
            {
                mid = (start + end) / 2;
                if (array[mid] > key) end = mid - 1;
                else if (array[mid] < key) start = mid + 1;
                else return mid;
            }
            return -1;
        }

        static void TestBinarySearch(int[] array, int key, int expected)
        {
            Console.WriteLine($"Array: {StringifyArray(array)}, Search Key: {key}");
            Console.WriteLine($"Result: {BinarySearch(array, key)}, Expected: {expected}");
        }

        static void Main(string[] args)
        {
            int[] testArray1 = new int[] { 4, 8, 15, 16, 23, 42 };
            int[] testArray2 = new int[] { 11, 22, 33, 44, 55, 66, 77 };
            int[] testArray3 = new int[] { 3, 6, 9, 12, 15 };
            int searchKey = 15;
            TestBinarySearch(testArray1, searchKey, 2);
            TestBinarySearch(testArray2, searchKey, -1);
            TestBinarySearch(testArray3, searchKey, 4);
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
