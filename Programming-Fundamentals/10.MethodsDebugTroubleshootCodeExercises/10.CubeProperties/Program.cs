namespace _10.CubeProperties
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            double cubeSide = double.Parse(Console.ReadLine());
            string parameterForCalculation = Console.ReadLine().ToLower().Trim();

            double result = PrintCubeProperties(cubeSide, parameterForCalculation);

            Console.WriteLine($"{result:F2}");
        }

        static double PrintCubeProperties(double cubeSide, string parameterForCalculation)
        {
            double result = 0.0;

            switch (parameterForCalculation)
            {
                case "face":
                    result = CalcCubeFaceDiagonal(cubeSide);
                    break;
                case "space":
                    result = CalcCubeSpaceDiagonal(cubeSide);
                    break;
                case "volume":
                    result = CalcCubeVolume(cubeSide);
                    break;
                case "area":
                    result = CalcCubeArea(cubeSide);
                    break;
                default:
                    Console.WriteLine("No such parameter");
                    break;
            }

            return result;
        }

        static double CalcCubeArea(double cubeSide)
        {
            double area = 6 * cubeSide * cubeSide;

            return area;
        }

        static double CalcCubeVolume(double cubeSide)
        {
            double volume = cubeSide * cubeSide * cubeSide;

            return volume;
        }

        static double CalcCubeSpaceDiagonal(double cubeSide)
        {
            double spaceDiagonal = Math.Sqrt(3) * cubeSide;

            return spaceDiagonal;
        }

        static double CalcCubeFaceDiagonal(double cubeSide)
        {
            double faceDiagonal = Math.Sqrt(2) * cubeSide;

            return faceDiagonal;
        }
    }
}
