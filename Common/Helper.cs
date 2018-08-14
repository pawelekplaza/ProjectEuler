using System;

namespace Common
{
    public static class Helper
    {
        public static long GetSumOfProperDivisors(long n)
        {
            long sum = 0;
            uint i = 2;
            while (i <= Math.Sqrt(n))
            {
                if (n % i == 0)
                {
                    sum += i;
                    if (i != (n / i))
                        sum += n / i;
                }
                i++;
            }

            return sum + 1;
        }

        public static bool IsAbundant(int n)
        {
            if (n < 12)
                return false;
            return n < GetSumOfProperDivisors(n);
        }
    }
}
