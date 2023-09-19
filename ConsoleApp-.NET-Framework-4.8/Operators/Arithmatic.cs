using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_.NET_Framework_4._8.Operators
{
    internal class Arithmatic
    {
        protected int A; 
        protected int B;

        //"A" and "B" is Accessible Within this Class
        //or in a class that is inherited from this class.

        public Arithmatic(int a, int b)     //Constructor with parameters
        {
            A = a; 
            B = b; 
        }

        public void ArithmaticOps ()    // Public Method
        {
            int X = A + B;
            Console.WriteLine($"Add(+): {X}");      //Concatenation: Interpolation
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
