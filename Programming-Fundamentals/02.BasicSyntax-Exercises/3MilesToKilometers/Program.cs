using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3MilesToKilometers
{
    class Program
    {
        static void Main(string[] args)
        {
            var miles = double.Parse(Console.ReadLine());
            var mile = 1.60934;

            var kilometers = miles * mile;
            Console.WriteLine("{0:F2}", kilometers);

        }
    }
}
