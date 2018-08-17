using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.ClosestTwoPoints
{
    class Program
    {
        static void Main(string[] args)
        {
            var pointsNumber = int.Parse(Console.ReadLine());
            var points = new List<Point>();
            var minDistancePoints = new List<Point>();

            for (int i = 0; i < pointsNumber; i++)
            {
                var pointCoordinates = Console.ReadLine().Split().Select(double.Parse).ToList();
                Point currentPoint = new Point { X = pointCoordinates[0], Y = pointCoordinates[1] };
                points.Add(currentPoint);
            }

            minDistancePoints = FindPointsMinDistance(points);
            Point minP1 = minDistancePoints[0];
            Point minP2 = minDistancePoints[1];
            double minDistance = CalcDistanceBetweenPoints(minP1, minP2);

            Console.WriteLine($"{minDistance:F3}");
            Console.WriteLine($"({minP1.X}, {minP1.Y})");
            Console.WriteLine($"({minP2.X}, {minP2.Y})");
        }

        static List<Point> FindPointsMinDistance(List<Point> points)
        {
            var minDistancePoints = new List<Point>();
            var minDistance = double.MaxValue;
            Point minP1 = new Point();
            Point minP2 = new Point();

            for (int i = 0; i < points.Count - 1; i++)
            {
                for (int j = i + 1; j < points.Count; j++)
                {
                    var p1 = points[i];
                    var p2 = points[j];
                    var distance = CalcDistanceBetweenPoints(p1, p2);

                    if (distance < minDistance)
                    {
                        minDistance = distance;
                        minP1 = p1;
                        minP2 = p2;
                    }
                }
            }

            minDistancePoints.Add(minP1);
            minDistancePoints.Add(minP2);

            return minDistancePoints;
        }

        static double CalcDistanceBetweenPoints(Point p1, Point p2)
        {
            double distance = 0.0;
            var diffX = p1.X - p2.X;
            var diffY = p1.Y - p2.Y;
            distance = Math.Sqrt(diffX * diffX + diffY * diffY);

            return distance;
        }
    }
}
