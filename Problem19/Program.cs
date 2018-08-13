using System;

namespace Problem19
{
    class Program
    {
        static void Main(string[] args)
        {
            int sundays = 0;
            var day = new DateTime(1901, 1, 1);
            var end = new DateTime(2000, 12, 31);
            while (day <= end)
            {
                if (day.DayOfWeek == DayOfWeek.Sunday && day.Day == 1)
                    sundays++;
                day = day.AddDays(1);
            }

            Console.WriteLine($"Sundays: { sundays }");
            Console.ReadLine();
        }
    }
}
