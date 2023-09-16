using ConsoleApp_.NET_Framework_4._8.Datatypes;
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

            DataType DtypeObj = new DataType();

            string a = "83";
            int b = DtypeObj.StrToNum(a);

            Console.WriteLine(b + " " + b.GetType());
        }
    }
}
