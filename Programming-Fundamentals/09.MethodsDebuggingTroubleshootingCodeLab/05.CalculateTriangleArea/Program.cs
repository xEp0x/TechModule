namespace _05.CalculateTriangleArea
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            double triangleArea = GetTriangleArea(width, height);
            Console.WriteLine(triangleArea);
        }

        static double GetTriangleArea(double width, double height)
        {
            double result = width * height / 2;
            return result;
        }
    }
}
