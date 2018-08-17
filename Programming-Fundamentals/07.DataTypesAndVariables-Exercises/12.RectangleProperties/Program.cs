using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.RectangleProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double rectanglePerimeter = 2 * (width + height);
            double rectangleArea = width * height;
            double rectangleDiagonal = Math.Sqrt(width * width + height * height);

            Console.WriteLine($"{rectanglePerimeter}\n{rectangleArea}\n{rectangleDiagonal}");
        }
    }
}
