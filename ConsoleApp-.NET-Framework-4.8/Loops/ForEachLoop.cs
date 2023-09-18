using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_.NET_Framework_4._8.Loops
{
    public class ForEachLoop : ForLoop // Inheritance
    {
        private readonly string[] LoopArray;

        public ForEachLoop(string[] loopArray)
        {
            LoopArray = loopArray;
        }

        public void ForEach ()
        {
            // Loop through the array elements

            foreach (string str in LoopArray)
            {
                Console.WriteLine($"This is {str}");
            }
        }
    }
}
