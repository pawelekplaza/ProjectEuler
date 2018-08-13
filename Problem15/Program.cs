using System;

namespace Problem15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Paths(20));
            Console.ReadKey(true);
        }

        static long Paths(long gridSize)
        {
            var size = gridSize + 1;
            var table = new long[size, size];
            table[0, 0] = 1;
            for (var row = 0; row < size; row ++)
            {
                for (var column = 0; column < size; column++)
                {
                    long sum = 0;
                    if (column - 1 >= 0)
                        sum += table[row, column - 1];

                    if (row - 1 >= 0)
                        sum += table[row - 1, column];

                    if (sum > 0)
                        table[row, column] = sum;
                }
            }

            return table[gridSize, gridSize];
        }
    }
}
