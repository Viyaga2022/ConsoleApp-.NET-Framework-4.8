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

            ForLoop myObj = new ForLoop();

            Console.WriteLine("================= For Loop =================\n");

            myObj.Run();

            Console.WriteLine("\n==============Nested For Loop================\n");

            myObj.NestedForLoop();
        
        }
    }
}
