using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_.NET_Framework_4._8.Operators
{
    internal class Comparision : Unary //Multi Level Inheritance
    {
        public Comparision (int a, int b) : base (a, b)
        {

        }

        public void ComparisionOpr ()
        {
            Console.WriteLine($"A = {A}, B = {B}");

            // Equal to
            string result1 = (A == B) ? "A == B: A equal to B": "A == B: A not equal to B";
            Console.WriteLine(result1);

            //Not Equal
            string result2 = (A != B) ? "A != B: A Not equal to B" : "A != B: A Equal to B";
            Console.WriteLine(result2);

            // Greater than
            string result3 = (A > B) ? "A > B: A greater than B" : "A > B: A not greater than B";
            Console.WriteLine(result3);

            //Less than
            string result4 = (A < B) ? "A < B: A less than B" : "A < B: A not less than B";
            Console.WriteLine(result4);

            // Greater than or equal to
            string result5 = (A >= B) ? "A >= B: A greater than or equal to B" : "A >= B: A not greater than or equal to B";
            Console.WriteLine(result5);

            //Less than or equal to
            string result6 = (A <= B) ? "A <= B: A less than or equal to B" : "A <= B: A not less than or equal to B";
            Console.WriteLine(result6);
        }
    }
}
