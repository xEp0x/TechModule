using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.RefactorVolumeOfPyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Length: ");
            double baseLength = double.Parse(Console.ReadLine());

            Console.Write("Width: ");
            double baseWidth = double.Parse(Console.ReadLine());

            Console.Write("Height: ");
            double pyramidHeight = double.Parse(Console.ReadLine());

            double volumePyramid = (baseLength * baseWidth * pyramidHeight) / 3;
            Console.WriteLine("Pyramid Volume: {0:F2}", volumePyramid);

        }
    }
}
