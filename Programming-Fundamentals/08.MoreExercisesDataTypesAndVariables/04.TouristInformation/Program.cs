using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.TouristInformation
{
    class Program
    {
        static void Main(string[] args)
        {
            string imperialUnit = Console.ReadLine().ToLower();
            string valueToConvert = Console.ReadLine();
            double numberToConvert = 0;
            bool isValueToConvertInteger = double.TryParse(valueToConvert, out numberToConvert);
            string metricUnit = string.Empty;        

            switch (imperialUnit)
            {
                case "miles":
                    numberToConvert = 1.6 * numberToConvert;
                    metricUnit = "kilometers";
                    break;
                case "inches":
                    numberToConvert = 2.54 * numberToConvert;
                    metricUnit = "centimeters";
                    break;
                case "feet":
                    numberToConvert = 30 * numberToConvert;
                    metricUnit = "centimeters";
                    break;
                case "yards":
                    numberToConvert = 0.91 * numberToConvert;
                    metricUnit = "meters";
                    break;
                case "gallons":
                    numberToConvert = 3.8 * numberToConvert;
                    metricUnit = "liters";
                    break;
            }

            Console.WriteLine($"{valueToConvert} {imperialUnit} = {numberToConvert:F2} {metricUnit}");

        }
    }
}
