namespace _09.HolidaysBetweenTwoDates
{
    using System;
    using System.Globalization;

    class Program
    {
        static void Main(string[] args)
        {
            var startDate = DateTime.ParseExact(Console.ReadLine(),
                "d.M.yyyy", CultureInfo.InvariantCulture);
            var endDate = DateTime.ParseExact(Console.ReadLine(),
                "d.M.yyyy", CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.WriteLine(startDate);
            Console.WriteLine(endDate);

            var holidaysCount = 0;
            for (var date = startDate; date <= endDate; date.AddDays(1))
            {
                if (date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday)
                {
                    holidaysCount++;
                }

            }

            Console.WriteLine(holidaysCount);
        }
    }
}
