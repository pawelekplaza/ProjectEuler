using System;
using System.Diagnostics;

namespace Problem18
{
    class Program
    {
        static void Main(string[] args)
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            var engine = new Engine();
            Console.WriteLine($"Sum: { engine.GetSum() }");
            Console.WriteLine($"Time of processing: { stopwatch.ElapsedMilliseconds } ms.");            
            Console.ReadLine();
        }        
    }
}
