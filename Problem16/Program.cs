using System;
using System.Numerics;

namespace Problem16
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = new BigInteger(1);
            for (var i = 1; i <= 1000; i++)
                number *= 2;

            var numberAsString = number.ToString();
            int sumOfDigits = 0;
            foreach (var c in numberAsString)
                sumOfDigits += int.Parse(c.ToString());

            Console.WriteLine(sumOfDigits);
            Console.ReadKey(true);
        }
    }
}
