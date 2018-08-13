using System;
using System.Linq;

namespace Problem20
{
    class Program
    {
        static void Main(string[] args)
        {
            var factorial = new Factorial();
            var result = factorial.Get(100);
            var digits = result.ToString().Select(v => v);
            var sum = digits.Sum(v => int.Parse(v.ToString()));
            Console.WriteLine($"Sum: { sum }");
            Console.ReadLine();
        }
    }
}
