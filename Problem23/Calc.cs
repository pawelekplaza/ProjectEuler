using Common;
using System.Collections.Generic;

namespace Problem23
{
    public class Calc
    {
        private Dictionary<int, List<int>> _cache = new Dictionary<int, List<int>>();

        public int GetProblemResult(int max)
        {
            int sum = 0;
            for (int i = 0; i <= max; i++)
            {
                if (!CanBeWrittenAsSumOfTwoAbundants(i))
                    sum += i;
            }
            return sum;
        }

        private bool CanBeWrittenAsSumOfTwoAbundants(int n)
        {
            var lessAbundants = GetLessAbundants(n);
            for (int i = 0; i < lessAbundants.Count; i++)
            {
                for (int j = lessAbundants.Count - 1; j >= i; j--)
                {
                    if (lessAbundants[i] + lessAbundants[j] == n)
                        return true;
                }
            }
            return false;
        }

        private List<int> GetLessAbundants(int n)
        {
            if (_cache.ContainsKey(n))
                return _cache[n];
            if (n < 12)
                return new List<int>();

            var abundants = new List<int>();
            int i = n - 1;
            while (!_cache.ContainsKey(i) && i >= 12)
            {
                if (Helper.IsAbundant(i))
                    abundants.Add(i);
                i--;
            };
            if (Helper.IsAbundant(i))
                abundants.Add(i);
            abundants.AddRange(GetLessAbundants(i));

            if (abundants.Count > 0)
            {
                _cache[n] = abundants;
                return _cache[n];
            }
            else
                return new List<int>();
        }
    }
}
