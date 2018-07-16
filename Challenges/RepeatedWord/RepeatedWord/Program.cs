using System;
using Hashtables.Classes;
using System.Text.RegularExpressions;

namespace RepeatedWord
{
    public class Program
    {
        /// <summary>
        /// Finds the first repeated word in a string.
        /// </summary>
        /// <param name="input">A string containing multiple words.</param>
        /// <returns>The first repeated word in the input string.</returns>
        public static string RepeatedWord(string input)
        {
            string[] wordArray = Regex.Split(input.ToLower(), @"\W+");
            Hashtable<int> wordTable = new Hashtable<int>();
            foreach(string word in wordArray)
            {
                if (wordTable.Contains(word)) return word;
                else wordTable.Add(word, 0);
            }
            return "";
        }

        static void Main(string[] args)
        {
            string myString = "The quick brown fox jumps over the lazy dog.";
            Console.WriteLine($"Input: {myString}");
            Console.WriteLine($"Output: {RepeatedWord(myString)}");
            Console.ReadKey();
        }
    }
}
