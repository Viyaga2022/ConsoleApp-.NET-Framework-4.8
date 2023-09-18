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

            string[] array = { "string 1", "string 2", "string 3", "string 4", "string 5" };

            ForEachLoop myObj = new ForEachLoop(array);

            myObj.ForEach();
        }
    }
}
