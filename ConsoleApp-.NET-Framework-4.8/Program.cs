using System;
using ConsoleApp_.NET_Framework_4._8.Arrays;
using ConsoleApp_.NET_Framework_4._8.Loops;


namespace ConsoleApp_.NET_Framework_4._8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /****************************************************************
             * 
             *  Learn C# Basics
             *  
             ****************************************************************/

            string[] strArray = { "BMW", "Volvo", "Ford", "Mazda", "Audi" };

            int[] intArray = { 34, 13, 98, 30, 63, 894, 43 };

            int[,] mulIntArray = {{1, 2, 3}, {4, 5, 6}};

            ArrayMethods myObj = new ArrayMethods(strArray, intArray, mulIntArray);

            myObj.ArrayOprs();
        }
    }
}
