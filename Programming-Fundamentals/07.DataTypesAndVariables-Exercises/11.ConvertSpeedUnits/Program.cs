using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.ConvertSpeedUnits
{
    class Program
    {
        static void Main(string[] args)
        {
            int distanceInMeters = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int seconds = int.Parse(Console.ReadLine());
            int oneMile = 1609;
            int timeInSeconds = seconds + 60 * minutes + 60 * 60 * hours;
            float timeInHours = timeInSeconds / (60.0f * 60.0f);

            float speedMeterPerSeconds = distanceInMeters * 1.0f / timeInSeconds;
            float speedKilometerPerHour = (distanceInMeters / 1000.0f) / timeInHours;
            float speedMilePerHour = (distanceInMeters *1.0f / oneMile) / timeInHours;

            

            Console.WriteLine("{0}", speedMeterPerSeconds);
            Console.WriteLine("{0}", speedKilometerPerHour);
            Console.WriteLine("{0}", speedMilePerHour);
                                           
            


        }
    }
}
