using Humanizer;
using System;

namespace Problem17
{
    class Program
    {
        static void Main(string[] args)
        {
            var culture = new System.Globalization.CultureInfo("en-US");
            int sum = 0;
            for (var i = 1; i <= 1000; i++)
            {
                var str = i.ToWords(culture);                
                foreach (var c in str)
                {
                    if (char.IsLetter(c))
                        sum++;
                }
            }

            Console.WriteLine(sum);
            Console.ReadKey(true);
        }
    }
}
