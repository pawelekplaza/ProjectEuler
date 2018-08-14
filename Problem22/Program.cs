using System;
using System.Diagnostics;
using System.IO;
using System.Numerics;

namespace Problem22
{
    class Program
    {
        static void Main(string[] args)
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();

            var names = File.ReadAllText("names.txt").Replace("\"", "").Split(',');
            Array.Sort(names);
            Console.WriteLine($"Result: { GetScoreSum(names) }");

            stopwatch.Stop();
            Console.WriteLine($"Time: { stopwatch.ElapsedMilliseconds } ms.");
            Console.ReadLine();
        }

        private static BigInteger GetScoreSum(string[] names)
        {
            BigInteger score = new BigInteger(0);
            for (int i = 0; i < names.Length; i++)
                score += GetScore(names[i], i);
            return score;
        }

        private static long GetScore(string name, int index)
        {
            long score = 0;
            for (int i = 0; i < name.Length; i++)
                score += name[i] - 'A' + 1;
            return (index + 1) * score;
        }
    }
}
