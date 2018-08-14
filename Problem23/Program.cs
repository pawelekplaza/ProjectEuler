using System;
using System.Diagnostics;

namespace Problem23
{
    class Program
    {
        static void Main(string[] args)
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            var calc = new Calc();
            Console.WriteLine($"Result: { calc.GetProblemResult(20161) }");
            stopwatch.Stop();
            Console.WriteLine($"Time: { stopwatch.ElapsedMilliseconds } ms.");
            Console.ReadLine();
        }
    }
}
