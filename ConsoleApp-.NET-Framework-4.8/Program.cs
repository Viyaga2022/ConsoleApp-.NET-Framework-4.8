using System;
using ConsoleApp_.NET_Framework_4._8.DecisionMaking;
using ConsoleApp_.NET_Framework_4._8.Operators;

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

            Unary myObj = new Unary(10, 5);
            myObj.UnaryOpr();
        }
    }
}
