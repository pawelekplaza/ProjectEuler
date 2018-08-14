using Common;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace Problem21
{
    class Program
    {
        private const long NumberAmout = 10000;
        static void Main(string[] args)
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            var amicables = new List<long>();
            for (int i = 1; i < NumberAmout; i++)
            {
                var x = Helper.GetSumOfProperDivisors(i);
                var y = Helper.GetSumOfProperDivisors(x);
                if (x != y && i == y)
                    amicables.Add(i);
            }

            stopwatch.Stop();
            Console.WriteLine($"Sum: { amicables.Sum() }\tTime: { stopwatch.ElapsedMilliseconds } ms.");
            Console.ReadLine();
        }
    }
}
