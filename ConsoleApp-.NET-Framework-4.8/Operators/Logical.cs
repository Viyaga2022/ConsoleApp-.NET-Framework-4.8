using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_.NET_Framework_4._8.Operators
{
    internal class Logical : Comparision
    {
        public Logical (int a, int b) : base (a, b)
        {

        }

        public void LogicalOpr ()
        {
            Console.WriteLine($"A = {A}, B = {B}");

            // And &&
            if (A > 10 && B > 10)
            {
                Console.WriteLine($"A > 10 && B > 10 These two statements are true so it returns {A > 10 && B > 10}.");
            } else
            {
                Console.WriteLine($"A > 10 && B > 10 One of the statement are both are false so it returns {A > 10 && B > 10}.");
            }

            // or ||
            if (A > 10 || B > 10)
            {
                Console.WriteLine($"A > 10 || B > 10. One of the statement are both are true so it returns  {A > 10 || B > 10}.");
            } 
            else
            {
                Console.WriteLine($"A > 10 || B > 10. These Both statements are false so it returns {A > 10 || B > 10}.");
            }

            // NOT !
            Console.WriteLine($"!(A > 10). Reverse the result, returns {!(A > 10)} if the result is {A > 10}");
        }
    }
}
