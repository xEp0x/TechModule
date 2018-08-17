using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.SortTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> times = Console.ReadLine().Split().ToList();

            var orderedTimes = times.OrderBy(time => time); 

            Console.WriteLine(string.Join(", ", orderedTimes));
        }
    }
}
