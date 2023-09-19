using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_.NET_Framework_4._8.Loops
{
    public class ForLoop
    {
        public void ForLoopRun()        // Public Method
        {
            for(int i = 1; i <= 10; i++)
            {
                if (i == 5)
                {
                    continue;
                }

                Console.WriteLine($"For Loop runs {i} time.");   //Concatenation: Interpolation     
            }
        }

        public void NestedForLoop()
        {
            for(int i = 1; i <= 5; i++) // Loop name A
            {
                if (i == 4)
                {
                    break;
                }

                Console.WriteLine($"=========> A Loop Runs {i} time.");

                for (int j = 1; j <= 5; j++) // Loop name B
                {
                    Console.WriteLine($"B Loop Runs {j} time.");
                }
            }
        }
    }
}
