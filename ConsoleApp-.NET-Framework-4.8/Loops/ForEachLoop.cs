using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_.NET_Framework_4._8.Loops
{
    public class ForEachLoop : ForLoop // Inheritance.
                                       // ForLoop: Base Class, ForEachLoop: Derived class
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
                Console.WriteLine($"ForEachLoop: This is {str}");
            }
        }
    }
}
