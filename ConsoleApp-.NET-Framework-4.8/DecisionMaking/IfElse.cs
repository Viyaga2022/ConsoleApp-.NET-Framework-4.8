using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_.NET_Framework_4._8.DecisionMaking
{
    internal class IfElse
    {
        private readonly int A;
        private readonly int B;

        public IfElse(int a, int b)
        {
            A = a;
            B = b;
        }

        public void Compare ()
        {
            if (A == B)
            {
                Console.WriteLine("A Equals B");
            }
            else if (A < B) 
            {
                Console.WriteLine("A is Younger than B");

                if ((B - A) > 5)
                {
                    Console.WriteLine("We have more than 5 Years differents");
                } else
                {
                    Console.WriteLine("We have less than 5 years differents");
                }
            }
            else
            {
                Console.WriteLine("A is Older than B");

                if ((A - B) > 5)
                {
                    Console.WriteLine("We have more than 5 Years differents");
                }
                else
                {
                    Console.WriteLine("We have less than 5 years differents");
                }
            }
        }
    }
}
