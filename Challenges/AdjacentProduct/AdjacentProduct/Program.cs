using System;

namespace AdjacentProduct
{
    public class Program
    {
        /// <summary>
        /// Compares two integers, and returns the greater of the two.
        /// </summary>
        /// <param name="first">The first integer being compared.</param>
        /// <param name="second">The second integer being compared.</param>
        /// <returns>Returns the greater integer.</returns>
        public static int ReturnGreater(int first, int second)
        {
            if (first > second) return first;
            else return second;
        }

        /// <summary>
        /// Finds the greatest product of two adjacent elements in a two-dimensional array.
        /// </summary>
        /// <param name="array">The two-dimensional array to be searched.</param>
        /// <returns>Returns the greatest product.</returns>
        public static int LargestProduct(int[,] array)
        {
            int current;
            int currentProd;
            int maxProd = int.MinValue;
            int height = array.GetLength(0);
            int width = array.GetLength(1);
            bool notLastRow;

            for (int i = 0; i < height; i++)
            {
                notLastRow = i < height - 1;
                for (int j = 0; j < width; j++)
                {
                    current = array[i, j];
                    if (notLastRow)
                    {
                        currentProd = current * array[i + 1, j];
                        maxProd = ReturnGreater(maxProd, currentProd);

                        if (j > 0)
                        {
                            currentProd = current * array[i + 1, j - 1];
                            maxProd = ReturnGreater(maxProd, currentProd);
                        }
                    }

                    if (j < width - 1)
                    {
                        currentProd = current * array[i, j + 1];
                        maxProd = ReturnGreater(maxProd, currentProd);

                        if (notLastRow)
                        {
                            currentProd = current * array[i + 1, j + 1];
                            maxProd = ReturnGreater(maxProd, currentProd);
                        }
                    }
                }
            }
            if (maxProd == int.MinValue)
            {
                throw new Exception();
            }
            else
            {
                return maxProd;
            }
        }

        static void Main(string[] args)
        {
            int[,] testArray = new int[,] { { 1, 2, 3 }, { 2, 4, 0 }, { 5, -1, 2 }, { -2, 2, 6 } };
            try
            {
                Console.WriteLine(LargestProduct(testArray));
            }
            catch (Exception ex)
            {
                Console.WriteLine("Something has gone wrong!");
            }
            finally
            {
                Console.ReadKey();
            } 
        }
    }
}
