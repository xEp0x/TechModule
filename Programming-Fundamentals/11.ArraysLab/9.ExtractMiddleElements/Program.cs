using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.ExtractMiddleElements
{
    class Program
    {
        static void Main(string[] args)
        {
            const char delimiter = ' ';

            int[] nums = Console.ReadLine().Split(delimiter).Select(int.Parse).ToArray();

            if (nums.Length == 1)
            {
                Console.WriteLine($"{{ {nums[0]} }}");
            }
            else if (nums.Length % 2 == 0)
            {
                int leftIndex = (nums.Length - 1) / 2;
                int rightIndex = (nums.Length - 1) / 2 + 1;
                Console.WriteLine($"{{ {nums[leftIndex]}, {nums[rightIndex]} }}");
            }
            else
            {
                int leftIndex = nums.Length / 2 - 1;
                int middleIndex = nums.Length / 2;
                int rightIndex = nums.Length / 2 + 1;
                Console.WriteLine($"{{ {nums[leftIndex]}, {nums[middleIndex]}, {nums[rightIndex]} }}");
            }

        }
    }
}
