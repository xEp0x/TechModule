namespace _09.LongerLine
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            //const double zeroPointX = 0;
            //const double zeroPointY = 0;

            double pointOneLine1X = double.Parse(Console.ReadLine());  //first point first line
            double pointOneLine1Y = double.Parse(Console.ReadLine());  //first point first line
            double pointTwoLine1X = double.Parse(Console.ReadLine());  //second point first line
            double pointTwoLine1Y = double.Parse(Console.ReadLine());  //second point first line

            double pointOneLine2X = double.Parse(Console.ReadLine());  //first point second line
            double pointOneLine2Y = double.Parse(Console.ReadLine());  //first point second line
            double pointTwoLine2X = double.Parse(Console.ReadLine());  //second point second line
            double pointTwoLine2Y = double.Parse(Console.ReadLine());  //second point second line

            double line1Length = CalcLineLength(pointOneLine1X, pointOneLine1Y, pointTwoLine1X, pointTwoLine1Y);
            double line2Length = CalcLineLength(pointOneLine2X, pointOneLine2Y, pointTwoLine2X, pointTwoLine2Y);

            if (line1Length >= line2Length)
            {
                PrintLinePointCoordinates(pointOneLine1X, pointOneLine1Y, pointTwoLine1X, pointTwoLine1Y);                
            }
            else
            {
                PrintLinePointCoordinates(pointOneLine2X, pointOneLine2Y, pointTwoLine2X, pointTwoLine2Y);                
            }    
        }

        // prints the coordinates of the points of longer line and starts with point coordinates closer to zero point
        static void PrintLinePointCoordinates(double pointOneX, double pointOneY, double pointTwoX, double pointTwoY) 
        {
            double pointOneToZero = CalcDistanceToZeroPoint(pointOneX, pointOneY);
            double pointTwoToZero = CalcDistanceToZeroPoint(pointTwoX, pointTwoY);

            if (pointOneToZero <= pointTwoToZero)
            {
                Console.WriteLine($"({pointOneX}, {pointOneY})({pointTwoX}, {pointTwoY})"); //
            }
            else
            {
                Console.WriteLine($"({pointTwoX}, {pointTwoY})({pointOneX}, {pointOneY})"); //
            }
        }

        static double CalcDistanceToZeroPoint(double pointX, double pointY)
        {
            double distanceToZero = Math.Sqrt(pointX * pointX + pointY * pointY);

            return distanceToZero;
        }

        static double CalcLineLength(double pointOneX, double pointOneY, double pointTwoX, double pointTwoY)
        {
            double differenceX = Math.Abs(pointOneX - pointTwoX);
            double differenceY = Math.Abs(pointOneY - pointTwoY);

            double lineLength = Math.Sqrt(differenceX * differenceX + differenceY * differenceY);

            return lineLength;
        }
    }
}
