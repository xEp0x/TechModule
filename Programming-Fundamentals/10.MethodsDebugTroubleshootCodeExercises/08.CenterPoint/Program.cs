namespace _08.CenterPodouble
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            //const double zeroPointX = 0;
            //const double zeroPointY = 0;

            double pointOneX = double.Parse(Console.ReadLine());  //first point
            double pointOneY = double.Parse(Console.ReadLine());  //first point
            double pointTwoX = double.Parse(Console.ReadLine());  //second point
            double pointTwoY = double.Parse(Console.ReadLine());  //second point

            PrintPointCoordinatesCloserToZeroPoint(pointOneX, pointOneY, pointTwoX, pointTwoY);
        }

        static void PrintPointCoordinatesCloserToZeroPoint(double pointOneX, double pointOneY, double pointTwoX, double pointTwoY)
        {
            double pointOneToZero = CalcDistanceToZeroPoint(pointOneX, pointOneY);
            double pointTwoToZero = CalcDistanceToZeroPoint(pointTwoX, pointTwoY);

            if (pointOneToZero <= pointTwoToZero)
            {
                Console.WriteLine($"({pointOneX}, {pointOneY})");
            }
            else
            {
                Console.WriteLine($"({pointTwoX}, {pointTwoY})");
            }
        }

        static double CalcDistanceToZeroPoint(double pointX, double pointY)
        {
            double distanceToZero = Math.Sqrt(pointX * pointX + pointY * pointY);

            return distanceToZero;
        }
    }
}
