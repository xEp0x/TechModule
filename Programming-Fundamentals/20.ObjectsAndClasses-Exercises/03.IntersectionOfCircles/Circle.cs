using System;

namespace _03.IntersectionOfCircles
{
    public class Circle
    {
        public double Radius { get; set; }
        public Point Center { get; set; }

        public bool Intersects(Circle other)
        {
            var distanceBetweenCenters = this.Center.DistanceTo(other.Center);

            var radiuses = this.Radius + other.Radius;

            return distanceBetweenCenters <= radiuses;
        }
    }
}
