using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.SumReversedNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            const char delimiter = ' ';

            List<int> nums = Console.ReadLine().Split(delimiter).Select(int.Parse).ToList();

            long sum = 0;
            for (int i = 0; i < nums.Count; i++)
            {
                nums[i] = ReverseDigitsElement(nums[i]);
                sum += nums[i];
            }

            Console.WriteLine(sum);
        }

        static int ReverseDigitsElement(int number)
        {
            int reverse = 0;
            while (number > 0)
            {
                int remainder = number % 10;
                reverse = (reverse * 10) + remainder;
                number = number / 10;
            }
            return reverse;
        }
    }
}
