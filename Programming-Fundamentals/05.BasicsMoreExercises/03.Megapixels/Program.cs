using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Megapixels
{
    class Program
    {
        static void Main(string[] args)
        {
            var width = int.Parse(Console.ReadLine());
            var heigth = int.Parse(Console.ReadLine());

            var resolutionInMpixel = (width * heigth) / 1000000.0;
            resolutionInMpixel = Math.Round(resolutionInMpixel, 1);

            Console.WriteLine($"{width}x{heigth} => {resolutionInMpixel}MP");

        }
    }
}
