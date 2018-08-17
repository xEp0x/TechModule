using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.OddFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split().Select(int.Parse).ToList();

            var numsWithoutOdd = nums.Where(num => num % 2 == 0);
            var average = numsWithoutOdd.Average();
            var numsEvenToOdd = numsWithoutOdd.Select(num => (num <= average) ? num - 1 : num + 1);

            Console.WriteLine(String.Join(" ", numsEvenToOdd));
        }
    }
}
