using System;

namespace MultiBracketValidation
{
    public class Program
    {
        /// <summary>
        /// Finds the index of the first instance of an opening bracket in a string, or -1 if none are found.
        /// </summary>
        /// <param name="input">The string being searched.</param>
        /// <returns>The index of the first opening bracket.</returns>
        public static int FindStartIndex(string input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '{' || input[i] == '(' || input[i] == '[')
                {
                    return i;
                }
            }
            return -1;
        }

        /// <summary>
        /// Finds the index of the bracket that closes the given opening bracket, or -1 if the bracket isn't closed.
        /// </summary>
        /// <param name="input">The string being searched.</param>
        /// <param name="left">The bracket being matched.</param>
        /// <param name="start">The position of the bracket being matched.</param>
        /// <returns>The index of the closing bracket.</returns>
        public static int FindEndIndex(string input, int start)
        {
            char right;
            switch (input[start])
            {
                case '{': right = '}'; break;
                case '(': right = ')'; break;
                default: right = ']'; break;
            }
            int count = 1;
            for (int i = start + 1; i < input.Length; i++)
            {
                if (input[i] == input[start]) count++;
                if (input[i] == right) count--;
                if (count == 0) return i;
            }
            return -1;
        }

        /// <summary>
        /// Checks if a string contains a closing bracket.
        /// </summary>
        /// <param name="input">The string being searched.</param>
        /// <returns>A boolean representing whether or not the string contains a closing bracket.</returns>
        public static bool HasRightBrackets(string input)
        {
            return (input.Contains('}') || input.Contains(')') || input.Contains(']'));
        }

        /// <summary>
        /// Checks if all opening brackets in a string are closed, and all closing brackets have a corresponding opening bracket.
        /// </summary>
        /// <param name="input">The string being checked.</param>
        /// <returns>A boolean representing whether or not the brackets are valid.</returns>
        public static bool MultiBracketValidation(string input)
        {
            int start = FindStartIndex(input);

            // If there are no left brackets, returns true if no right brakets are found, or false if there are.
            if (start == -1) return !HasRightBrackets(input);

            // Returns false if there are any right brackets before the first left braket. 
            else if (HasRightBrackets(input.Substring(0, start))) return false;
            int end = FindEndIndex(input, start);

            // If the left bracket isn't closed, return false.
            if (end == -1) return false;

            // Performs MultiBracketValidation on the string inside the brackets and the string after the brackets, and returns the result.
            else return MultiBracketValidation(input.Substring(start + 1, end - start -1)) && MultiBracketValidation(input.Substring(end + 1));
        }

        static void Main(string[] args)
        {
            Console.WriteLine(MultiBracketValidation("([)]"));
            Console.WriteLine(MultiBracketValidation("((((()))))[]{{}}"));
            Console.WriteLine(MultiBracketValidation("]["));
            Console.ReadKey();
        }
    }
}
