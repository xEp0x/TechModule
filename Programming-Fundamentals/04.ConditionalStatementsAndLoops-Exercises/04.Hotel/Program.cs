using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            var month = Console.ReadLine().ToLower();
            var nightsCount = int.Parse(Console.ReadLine());            
            var studioPrice = 0.0;
            var doublePrice = 0.0;
            var suitePrice = 0.0;

            switch (month)
            {
                case "may":                    
                case "october":
                    studioPrice = nightsCount * 50.0;                    
                    doublePrice = nightsCount * 65.0;
                    suitePrice = nightsCount * 75.0;
                    break;
                case "june":
                case "september":
                    studioPrice = nightsCount * 60.0;
                    doublePrice = nightsCount * 72.0;                                                                 
                    suitePrice = nightsCount * 82.0;
                    break;
                case "july":
                case "august":
                case "december":                    
                    studioPrice = nightsCount * 68.0;
                    doublePrice = nightsCount * 77.0;
                    suitePrice = nightsCount * 89.0;
                    break;
            }

            if (((month.Equals("may") || month.Equals("october")) && nightsCount > 7))
            {
                studioPrice -= studioPrice * 5 / 100;
            }

            if (((month.Equals("june") || month.Equals("september")) && nightsCount > 14))
            {
                doublePrice -= doublePrice * 10 / 100;
            }

            if (((month.Equals("july") || month.Equals("august") || month.Equals("december")) && nightsCount > 14))
            {
                suitePrice -= suitePrice * 15 / 100;
            }

            var endStudioPrice = studioPrice;

            if (((month.Equals("september") || month.Equals("october")) && nightsCount > 7))
            {
                endStudioPrice = endStudioPrice - studioPrice / nightsCount;
            }

            Console.WriteLine($"Studio: {endStudioPrice:F2} lv.");
            Console.WriteLine($"Double: {doublePrice:F2} lv.");
            Console.WriteLine($"Suite: {suitePrice:F2} lv.");
        }
    }
}
