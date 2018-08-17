using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.CircleArea_12DigitsPrecision_
{
    class Program
    {
        static void Main(string[] args)
        {
            double circleRadius = double.Parse(Console.ReadLine());

            double circleArea = Math.PI * circleRadius * circleRadius;

            Console.WriteLine($"{circleArea:F12}");
        }
    }
}
