using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.SplinterTrip
{
    class Program
    {
        static void Main(string[] args)
        {
                //double consumption = 25.00;
                double allMiles = double.Parse(Console.ReadLine());
                double tankCapacity = double.Parse(Console.ReadLine());
                double milesInWinds = double.Parse(Console.ReadLine());

                double consumptionWithoutWind = (allMiles - milesInWinds) * 25;
                double consumptionInWind = 1.5 * milesInWinds * 25;

                double allTripConsumption = (consumptionWithoutWind + consumptionInWind) * 1.05; //5% just in case

                Console.WriteLine($"Fuel needed: {allTripConsumption:F2}L");

                double diff = tankCapacity - allTripConsumption;

                Console.WriteLine(diff >= 0 ? $"Enough with {diff:F2}L to spare!" : $"We need {Math.Abs(diff):F2}L more fuel.");
            
        }
    }
}
