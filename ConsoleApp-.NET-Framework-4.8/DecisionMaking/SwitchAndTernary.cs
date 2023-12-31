﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_.NET_Framework_4._8.DecisionMaking
{
    internal class SwitchAndTernary : IfElse  // Single Inheritance.
                                              // IfElse: Base class, SwitchAndTernary: Derived Class
    {
        private readonly int A;     // Encapsulation. Private Access Modifier. 
        private readonly int B;     // A and B are accessible within this class only

        // Constructor ==========
        public SwitchAndTernary(int a, int b) : base(a, b)  // Argument passed to the base class
        {
            A = a;
            B = b;
        }

        public void Compare2()      // Public Method
        {

            // Ternary operator =============

            int c = (A < B) ? 1 : (A > B) ? 2 : 0; 

            // Switch Statement =============

            switch (c)
            {
                case 0:
                    Console.WriteLine("A and B are in same age");
                    break;
                case 1:
                    Console.WriteLine("A Younger than B");
                    break;
                default:
                    Console.WriteLine("B Younger than A");
                    break;
            }
        }
    }
}
