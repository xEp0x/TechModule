using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.ArrayStatistics
{
    class Program
    {
        static void Main(string[] args)
        {
            const char delimiter = ' ';

            int[] nums = Console.ReadLine().Split(delimiter).Select(int.Parse).ToArray();

            int minValue = CalcMinValue(nums);
            int maxValue = CalcMaxValue(nums);
            long sum = CalcSumArrElements(nums);
            double avarageValue = sum * 1.0 / nums.Length;

            Console.WriteLine($"Min = {minValue}");
            Console.WriteLine($"Max = {maxValue}");
            Console.WriteLine($"Sum = {sum}");
            Console.WriteLine($"Average = {avarageValue}");

        }

        private static long CalcSumArrElements(int[] nums)
        {
            long sum = 0;

            foreach (int element in nums)
            {
                sum += element;
            }

            return sum;
        }

        private static int CalcMaxValue(int[] nums)
        {
            int maxValue = int.MinValue;

            for (int i = 0; i < nums.Length; i++)
            {
                if (maxValue < nums[i])
                {
                    maxValue = nums[i];
                }
            }

            return maxValue;
        }

        static int CalcMinValue(int[] nums)
        {
            int minValue = int.MaxValue;

            for (int i = 0; i < nums.Length; i++)
            {
                if (minValue > nums[i])
                {
                    minValue = nums[i];
                }
            }

            return minValue;
        }
    }
}
