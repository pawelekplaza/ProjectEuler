using System;

namespace Problem12
{
    class Program
    {
        static void Main(string[] args)
        {
            var triangleNumber = new TriangleNumber(1, 1);
            while (true)
            {
                triangleNumber.NextNumber();
                if (triangleNumber.GetNumberOfDivisors() > 500)
                {
                    Console.WriteLine(triangleNumber.Number);
                    break;
                }
            }
            Console.ReadLine();
        }
    }

    public class TriangleNumber
    {
        public ulong Number { get; set; }
        /// <summary>
        /// Counting from 1.
        /// </summary>
        public uint Index { get; set; }

        public TriangleNumber(ulong n, uint index)
        {
            Number = n;
            Index = index;
        }

        public void NextNumber()
        {
            Number += ++Index;
        }

        public int GetNumberOfDivisors()
        {
            var divisors = 2;
            uint i = 2;
            while (i <= Math.Sqrt(Number))
            {
                if (Number % i == 0)
                {
                    divisors++;
                    if (i != (Number / i))
                        divisors++;
                }

                i++;
            }

            return divisors;
        }
    }
}