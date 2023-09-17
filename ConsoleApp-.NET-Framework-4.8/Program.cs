using System;
using ConsoleApp_.NET_Framework_4._8.DecisionMaking;


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

            SwitchAndTernary myObj = new SwitchAndTernary(16, 20);
            myObj.Compare1(); // This function is from base class
            myObj.Compare2(); // This function is from derived class
        }
    }
}
