using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_.NET_Framework_4._8.MathMethods
{
    internal class MathMethod
    {
        private readonly double A;   //Encapsulation
        private readonly double B;   // This code is only Accessible within this class

        public MathMethod(double a, double b) 
        {
            A = a;
            B = b;
        }

        public void MathFun()
        {
            Console.WriteLine($"A = {A}, B = {B}");

            Console.WriteLine($"Math.Max(A, B). It returns the highest value of A and B. " +
                $"Highest Value: {Math.Max(A, B)}");

            Console.WriteLine($"Math.Min(A, B). It returns the lowest value of A and B. " +
                $"Lowest Value: {Math.Min(A, B)}");

            Console.WriteLine($"Math.Sqrt(A). It returns the square root of A. " +
                $"Square root of A = {Math.Sqrt(A)}");

            Console.WriteLine($"Math.Abs(A). It returns the positive value of A. " +
                $"Positive Value of A: {Math.Abs(A)}");

            Console.WriteLine($"Math.Round(A). It rounds a number to the nearest whole number. " +
                $"Round of A: {Math.Round(A)}");
        }
    }
}
