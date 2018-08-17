namespace _11.GeometryCalculator
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            string figureType = Console.ReadLine();

            double result = CalcFugureArea(figureType);
            Console.WriteLine($"{result:F2}");
        }

        static double CalcFugureArea(string figureType)
        {
            double result = 0.0;

            switch (figureType)
            {
                case "triangle":
                    result = CalcTriangleArea();
                    break;
                case "square":
                    result = CalcSquareArea();
                    break;
                case "rectangle":
                    result = CalcRectangleArea();
                    break;
                case "circle":
                    result = CalcCircleArea();
                    break;
                default:
                    Console.WriteLine("No such figure!");
                    break;
            }

            return result;
        }

        static double CalcCircleArea()
        {
            double radius = double.Parse(Console.ReadLine());
            double area = Math.PI * radius * radius;

            return area;
        }

        static double CalcRectangleArea()
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double area = width * height;

            return area;
        }

        static double CalcSquareArea()
        {
            double side = double.Parse(Console.ReadLine());
            double area = side * side;

            return area;
        }

        static double CalcTriangleArea()
        {
            double side = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double area = side * height / 2;

            return area;
        }
    }
}
