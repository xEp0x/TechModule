using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.IntersectionOfCircles
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstCircleData = Console.ReadLine().Split().Select(double.Parse).ToList();
            var secondCircleData = Console.ReadLine().Split().Select(double.Parse).ToList();

            Circle firstCircle = new Circle();
            firstCircle.Center = new Point();
            Circle secondCircle = new Circle();
            secondCircle.Center = new Point();            

            firstCircle.Center.X = firstCircleData[0];
            firstCircle.Center.Y = firstCircleData[1];
            firstCircle.Radius = firstCircleData[2];

            secondCircle.Center.X = secondCircleData[0];
            secondCircle.Center.Y = secondCircleData[1];
            secondCircle.Radius = secondCircleData[2];

            var circleOneIntersectsCircle2 = firstCircle.Intersects(secondCircle);

            Console.WriteLine(circleOneIntersectsCircle2 ? "Yes" : "No");

        }
    }
}
