using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _01.CountWorkingDays
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime firstDate = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture);
            DateTime secondDate = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture);

            var count = 0;

            for (DateTime day = firstDate; day <= secondDate; day = day.AddDays(1))
            {
                var currentYear = firstDate.Year;
                var dayYear = day.Year;
                var result = dayYear - currentYear;

                var holidaysInBulgariaCurrentYear = new List<DateTime>
                {
                    new DateTime(currentYear+result, 1, 1),
                    new DateTime(currentYear+result, 3, 3),
                    new DateTime(currentYear+result, 5, 1),
                    new DateTime(currentYear+result, 5, 6),
                    new DateTime(currentYear+result, 5, 24),
                    new DateTime(currentYear+result, 9, 6),
                    new DateTime(currentYear+result, 9, 22),
                    new DateTime(currentYear+result, 11, 1),
                    new DateTime(currentYear+result, 12, 24),
                    new DateTime(currentYear+result, 12, 25),
                    new DateTime(currentYear+result, 12, 26),
                };

                bool isWeekend = day.DayOfWeek == DayOfWeek.Saturday || day.DayOfWeek == DayOfWeek.Sunday;
                bool isHoliday = holidaysInBulgariaCurrentYear.Contains(day);
                bool isNonWorkingDay = isWeekend || isHoliday;

                if (!isNonWorkingDay)
                {
                    count++;
                }
            }

            Console.WriteLine(count);
        }
    }
}
