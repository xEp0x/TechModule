using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.SquareNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            const char delimiter = ' ';

            int[] nums = Console.ReadLine().Split(delimiter).Select(int.Parse).ToArray();
            List<int> sqrtNums = new List<int>();

            foreach (var element in nums)
            {
                if (Math.Sqrt(element) == (int)Math.Sqrt(element))
                {
                    sqrtNums.Add(element);
                }
            }

            sqrtNums.Sort();
            sqrtNums.Reverse();
            Console.WriteLine(string.Join(" ", sqrtNums));
        }
    }
}
