using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem14
{
    class Program
    {
        static void Main(string[] args)
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();

            var collatz = new Collatz();
            uint longestChain = 0;
            ulong startingNumber = 0;
            for (ulong number = 1; number < 1000000; number++)
            {
                collatz.Number = number;
                var currentChain = collatz.GetNumberOfTerms();
                if (currentChain > longestChain)
                {
                    startingNumber = number;
                    longestChain = currentChain;
                }
            }

            Console.WriteLine("Longest chain: {0}", longestChain);
            Console.WriteLine("Starting number: {0}", startingNumber);
            Console.Write("Time: {0} ms", stopwatch.ElapsedMilliseconds);
            Console.ReadKey();
        }
    }    
}
