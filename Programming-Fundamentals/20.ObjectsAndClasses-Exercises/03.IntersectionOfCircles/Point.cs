using System;

namespace _03.IntersectionOfCircles
{
    public class Point
    {
        public double X { get; set; }
        public double Y { get; set; }

        public double DistanceTo(Point other)
        {
            double distance = 0.0;
            var diffX = this.X - other.X;
            var diffY = this.Y - other.Y;
            distance = Math.Sqrt(diffX * diffX + diffY * diffY);

            return distance;
        }
    }
}
