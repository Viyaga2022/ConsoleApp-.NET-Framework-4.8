using System;
//using ConsoleApp_.NET_Framework_4._8.Datatypes;
//using ConsoleApp_.NET_Framework_4._8.String;
using ConsoleApp_.NET_Framework_4._8.ConsoleMethods;


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

            _ConsoleMethods myObj = new _ConsoleMethods("Mohan", 23, "mohan@gmail.com", 9047123456);
            myObj.Hi();
            myObj.GetInput();
        }
    }
}
