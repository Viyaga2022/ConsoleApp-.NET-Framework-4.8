using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_.NET_Framework_4._8.Loops
{
    internal class WhileLoop
    {
        public void RunWhileLoop ()
        {
            int i = 1;

            while (i <= 10)     // check the condition then run the loop
            {
                Console.WriteLine($"While Loop runs {i} time.");

                i++;
            }
        }

        public void RunDoWhileLoop()
        {
            int i = 1;

            do          // Run the code 1st time then continue the loop
            {
                Console.WriteLine($"Do While Loop runs {i} time.");

                i++;

            } while (i <= 10);
        }
     }
}
