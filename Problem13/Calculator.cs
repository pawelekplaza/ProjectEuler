using System.Collections.Generic;
using System.Numerics;

namespace Problem13
{
    public class Calculator
    {
        public List<string> Numbers { get; set; }

        public Calculator(List<string> list)
        {
            Numbers = list;
        }

        public string GetFirstTenDigits()
        {
            var bigIntList = GetBigIntList();
            var sumOfBigInts = GetSum(bigIntList);
            var sumAsString = sumOfBigInts.ToString();

            return sumAsString.Substring(0, 10);
        }

        private List<BigInteger> GetBigIntList()
        {
            var bigIntList = new List<BigInteger>();
            foreach (var value in Numbers)
                bigIntList.Add(BigInteger.Parse(value));

            return bigIntList;
        }

        private BigInteger GetSum(List<BigInteger> list)
        {
            BigInteger sum = 0;
            foreach (var value in list)
                sum += value;

            return sum;
        }
    }
}
