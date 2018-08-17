using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.SortNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            const char delimiter = ' ';

            List<double> nums = Console.ReadLine().Split(delimiter).Select(double.Parse).ToList();

            nums.Sort();

            Console.WriteLine(string.Join(" <= ", nums));
        }
    }
}
