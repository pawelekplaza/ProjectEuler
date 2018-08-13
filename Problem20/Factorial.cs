using System.Numerics;

namespace Problem20
{
    public class Factorial
    {
        public BigInteger Get(BigInteger n)
        {
            if (n == 1)
                return 1;            
            return n * Get(n - 1);
        }
    }
}
