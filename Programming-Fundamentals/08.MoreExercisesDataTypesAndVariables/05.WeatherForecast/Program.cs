using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.WeatherForecast
{
    class Program
    {
        static void Main(string[] args)
        {
            string forecastNumber = Console.ReadLine();
            sbyte sbyteNumber = 0;
            int intNumber = 0;
            long longNumber = 0;

            bool isNumberSbyte = sbyte.TryParse(forecastNumber, out sbyteNumber);
            bool isNumberInt = int.TryParse(forecastNumber, out intNumber);
            bool isNumberLong = long.TryParse(forecastNumber, out longNumber);
            bool isNumberFloatingPoint = isNumberFloating(forecastNumber);

            if (isNumberSbyte)
            {
                Console.WriteLine("Sunny");
            }
            else
            {
                if (isNumberInt)
                {
                    Console.WriteLine("Cloudy");
                }
                else
                {
                    if (isNumberLong)
                    {
                        Console.WriteLine("Windy");
                    }
                    else
                    {
                        if (isNumberFloatingPoint)
                        {
                            Console.WriteLine("Rainy");
                        }
                    }
                }
            }

        }

        static bool isNumberFloating (string str)
        {
            bool isNumberFloatingPoint = false;
            char[] stringForFloatCheking = str.ToCharArray();

            foreach (char ch in stringForFloatCheking)
            {
                if (ch == '.')
                {
                    isNumberFloatingPoint = true;
                    break;
                }
            }
            return isNumberFloatingPoint;
        }

    }
}
