using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.DistanceBetweenPoints
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstPoint = Console.ReadLine().Split().Select(double.Parse).ToList();
            var secondPoint = Console.ReadLine().Split().Select(double.Parse).ToList();

            Point p1 = new Point { X = firstPoint[0], Y = firstPoint[1] };
            Point p2 = new Point { X = secondPoint[0], Y = secondPoint[1] };

            var distance = CalcDistanceBetweenPoints(p1, p2);
            Console.WriteLine($"{distance:F3}");
        }

        public static double CalcDistanceBetweenPoints(Point p1, Point p2)
        {
            double distance = 0.0;
            var diffX = p1.X - p2.X;
            var diffY = p1.Y - p2.Y;
            distance = Math.Sqrt(diffX * diffX + diffY * diffY);

            return distance;
        }
    }
}
