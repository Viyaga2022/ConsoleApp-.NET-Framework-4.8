using System;
using ConsoleApp_.NET_Framework_4._8.Loops;
using ConsoleApp_.NET_Framework_4._8.MathMethods;


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

            WhileLoop myObj = new WhileLoop();

            Console.WriteLine($"================ While Loop ==================\n");

            myObj.RunWhileLoop();

            Console.WriteLine($"\n============== Do While Loop ================\n");

            myObj.RunDoWhileLoop();
        }
    }
}
