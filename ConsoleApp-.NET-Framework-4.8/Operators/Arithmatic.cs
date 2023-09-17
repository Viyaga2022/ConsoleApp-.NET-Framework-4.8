using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_.NET_Framework_4._8.Operators
{
    internal class Arithmatic
    {
        private readonly int A;
        private readonly int B;

        public Arithmatic(int a, int b)
        {
            A = a; 
            B = b; 
        }

        public void ArithmaticOps ()
        {
            int X = A + B;
            Console.WriteLine($"Add(+): {X}");
            X = A - B;
            Console.WriteLine($"Sub(-): {X}");
            X = A * B;
            Console.WriteLine($"Mul(x): {X}");
            X = A / B;
            Console.WriteLine($"Div(/): {X}");
            X = A % B;
            Console.WriteLine($"Mod(%): {X}");
        }
    }
}
