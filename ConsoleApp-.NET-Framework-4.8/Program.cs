using System;
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

            string[] array = { "string 1", "string 2", "string 3", "string 4", "string 5" };

            WhileLoop myObj = new WhileLoop(array);

            Console.WriteLine($"================ While Loop: Continue ==================\n");

            myObj.ForLoopRun(); // With Continue Statement

            Console.WriteLine($"\n============== Do While Loop: Break; ================\n");

            myObj.NestedForLoop(); // With Break Statement
        }
    }
}
