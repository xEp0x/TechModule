using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.ComparingFloats
{
    class Program
    {
        static void Main(string[] args)
        {
            const double eps = 0.000001;

            double numA = double.Parse(Console.ReadLine());
            double numB = double.Parse(Console.ReadLine());

            //double diff = Math.Abs(Math.Abs(numA) - Math.Abs(numB));
            double diff = Math.Abs(numA - numB);
            //Console.WriteLine($"{diff:F16}");

            if (diff < eps)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }

        }
    }
}
