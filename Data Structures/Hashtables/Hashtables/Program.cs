using Hashtables.Classes;
using System;

namespace Hashtables
{
    public class Program
    {
        /// <summary>
        /// Creates a hashtable with a set of default buckets.
        /// </summary>
        /// <returns>A hashtable.</returns>
        public static Hashtable<int> MakeTable()
        {
            Hashtable<int> hashtable = new Hashtable<int>();
            hashtable.Add("Dog", 0);
            hashtable.Add("Doe", 17);
            hashtable.Add("Cat", 1);
            hashtable.Add("Fish", 2);
            hashtable.Add("Bird", 3);
            hashtable.Add("Cow", 4);
            hashtable.Add("Snake", 5);
            return hashtable;
        }

        static void Main(string[] args)
        {
            string[] animals = new string[] { "Dog", "Cat", "Doe", "Fish", "Bird", "Cow", "Snake" };

            Hashtable<int> hashtable = MakeTable();
            foreach(string animal in animals)
            {
                if (hashtable.Contains(animal))
                {
                    Console.WriteLine($"Key: {animal}, Hash: {hashtable.GetHash(animal)}, Value: {hashtable.Find(animal)}");
                }
            }
            Console.ReadKey();
        }
    }
}
