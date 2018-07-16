using System;
using System.Collections.Generic;
using System.Text;

namespace Hashtables.Classes
{
    public class Hashtable<T>
    {
        protected KeyValuePair<string, T>[] Table;

        /// <summary>
        /// Creates a new instance of the Hashtable class.
        /// </summary>
        public Hashtable()
        {
            Table = new KeyValuePair<string, T>[1024];
        }

        /// <summary>
        /// Adds a new bucket to the hashtable.
        /// </summary>
        /// <param name="key">The bucket's key.</param>
        /// <param name="value">The bucket's value.</param>
        public void Add(string key, T value)
        {
            if (!Contains(key))
            {
                int index = GetHash(key);
                while (index < Table.Length)
                {
                    if (Table[index].Key == null)
                    {
                        Table[index] = new KeyValuePair<string, T>(key, value);
                        return;
                    }
                    else index++;
                }
            }
            throw new Exception("Key is already in hashtable!");
        }

        /// <summary>
        /// Gets the value for a given key in the hashtable.
        /// </summary>
        /// <param name="key">The key being searched for.</param>
        /// <returns>The value associated with the key.</returns>
        public T Find(string key)
        {
            if (Contains(key))
            {
                int index = GetHash(key);
                while (index < Table.Length)
                {
                    if (Table[index].Key != key) index++;
                    else return Table[index].Value;
                }
            }
            throw new Exception("Key is not in hashtable!");
        }

        /// <summary>
        /// Checks if a key is present in the hashtable.
        /// </summary>
        /// <param name="key">The key being searched for.</param>
        /// <returns>A boolean representing if the key is present.</returns>
        public bool Contains(string key)
        {
            int index = GetHash(key);
            while (index < Table.Length)
            {
                if (Table[index].Key == key)
                {
                    return true;
                }
                else index++;
            }
            return false;
        }

        /// <summary>
        /// Generates an integer value based on a key's value.
        /// </summary>
        /// <param name="key">The key being hashed.</param>
        /// <returns>A number between 0 and 1023.</returns>
        public int GetHash(string key)
        {
            int hash = 0;
            foreach(char c in key)
            {
                hash += c;
            }
            hash *= 599;
            return hash % 1024;
        }
    }
}
