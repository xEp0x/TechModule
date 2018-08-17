using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Photo_Gallery
{
    class Program
    {
        static void Main(string[] args)
        {
            var photoNumber = int.Parse(Console.ReadLine());
            var day = int.Parse(Console.ReadLine());
            var month = int.Parse(Console.ReadLine());
            var year = int.Parse(Console.ReadLine());
            var hour = int.Parse(Console.ReadLine());
            var minute = int.Parse(Console.ReadLine());
            var sizeInBytes = int.Parse(Console.ReadLine());
            var size = 0.0;
            var width = int.Parse(Console.ReadLine());
            var heigth = int.Parse(Console.ReadLine());

            Console.WriteLine($"Name: DSC_{photoNumber:D4}.jpg");
            Console.WriteLine($"Date Taken: {day:D2}/{month:D2}/{year} {hour:D2}:{minute:D2}");

            if (sizeInBytes <= 1024)
            {
                size = sizeInBytes;
                Console.WriteLine($"Size: {size}B");
            }
            else
            {
                if (sizeInBytes <= 1048576)
                {
                    size = Math.Round(sizeInBytes / 1000.0, 1);
                    Console.WriteLine($"Size: {size}KB");
                }
                else
                {
                    size = Math.Round(sizeInBytes / 1000000.0, 1);
                    Console.WriteLine($"Size: {size}MB");
                }
            }

            if (width > heigth)
            {
                Console.WriteLine($"Resolution: {width}x{heigth} (landscape)");
            }
            else
            {
                if (width < heigth)
                {
                    Console.WriteLine($"Resolution: {width}x{heigth} (portrait)");                    
                }
                else
                {
                    Console.WriteLine($"Resolution: {width}x{heigth} (square)");
                }
            }            

        }
    }
}
