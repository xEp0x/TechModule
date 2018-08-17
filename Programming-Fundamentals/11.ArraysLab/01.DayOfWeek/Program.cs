namespace _01.DayOfWeek
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            string[] weekDay = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday", };
            int dayNumber = int.Parse(Console.ReadLine());

            if (1 <= dayNumber && dayNumber <= 7)
            {
                Console.WriteLine(weekDay[dayNumber - 1]);
            }
            else
            {
                Console.WriteLine("Invalid Day!");
            }
        }
    }
}
