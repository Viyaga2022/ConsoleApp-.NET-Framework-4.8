using ConsoleApp_.NET_Framework_4._8.Datatypes;
using ConsoleApp_.NET_Framework_4._8.String;
using System;

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

            Concatenation myObj = new Concatenation();

            string[] strArray = { "Hello", " Friends", " I am Mohan.", " I am from Tamilnadu." };

            string concatString = myObj.ConcatString(strArray);

            Console.WriteLine(concatString);

            string concatString1 = myObj.Interpolation(strArray);

            Console.WriteLine(concatString1);
        }
    }
}
