using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_.NET_Framework_4._8.Arrays
{
    internal class ArrayMethods
    {
        private readonly string[] StrArray = { };
        private readonly int[] IntArray = { };      // Single Dimensional Array
        private readonly int[,] MulIntArray = { };  //Multidimensional Array

        public ArrayMethods(string[] strArray, int[] intArray, int[,] mulIntArray)
        {
            StrArray = strArray;
            IntArray = intArray;
            MulIntArray = mulIntArray;
        }

        public void ArrayOprs()
        {
            Console.WriteLine($"Array Element(StrArray[0]): {StrArray[0]}");

            Console.WriteLine($"Array Length(StrArray.Length): {StrArray.Length}"); //Array Length

            Console.WriteLine($"IntArray Min (IntArray.Min()): {IntArray.Min()}"); //Smallest value

            Console.WriteLine($"IntArray Max (IntArray.Max()): {IntArray.Max()}"); //Largest Value

            Console.WriteLine($"IntArray Sum (IntArray.Sum()): {IntArray.Sum()}"); //Sum of values

            Array.Sort(StrArray);   // Sort String Array
            Array.Sort(IntArray);   // Sort Int Array

            Console.WriteLine("============== String Array Elements ==============\n");

            foreach (string str in StrArray)
            {
                Console.WriteLine(str);
            }

            Console.WriteLine("============== Int Array Elements ==============\n");

            foreach (int i in IntArray)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("========= Multidimensional Array Elements =========\n");

            Console.WriteLine($" MulArray Length: (MulIntArray.GetLength(0)): {MulIntArray.GetLength(0)}\n");
            Console.WriteLine($" InsideArray Length: (InsideArray.GetLength(1)): {MulIntArray.GetLength(1)}");

            for (int i = 0; i < MulIntArray.GetLength(0); i++)
            {
                for(int j = 0; j < MulIntArray.GetLength(1); j++)
                {
                    Console.WriteLine(MulIntArray[i, j]);
                }
            }
        }
    }
}
