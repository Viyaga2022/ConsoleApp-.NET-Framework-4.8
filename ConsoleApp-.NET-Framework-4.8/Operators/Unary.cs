using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_.NET_Framework_4._8.Operators
{
    internal class Unary : Arithmatic
    {
        public Unary(int a, int b) : base(a, b)
        {

        }

        public void UnaryOpr ()
        {
            //int a = A++;
            Console.WriteLine($"A = {A}, B = {B}");

            Console.WriteLine($"Post Increment A++ : {A++}." +
                $" After Post Incrment A = {A}.");

            Console.WriteLine($"Pre Increment ++A : {++A}." +
                $" After Pre Increment A = {A}.");

            Console.WriteLine($"Post Decrement --A : {A--}." +
                $" After Post Decrement A = {A}.");

            Console.WriteLine($"Pre Decrement A-- : {--A}." +
                $" After Pre Decrement A = {A}.");
        }
    }
}
