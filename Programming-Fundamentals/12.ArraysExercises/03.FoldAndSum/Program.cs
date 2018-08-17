using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.FoldAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            const char delimiter = ' ';

            int[] nums = Console.ReadLine().Split(delimiter).Select(int.Parse).ToArray();
            int length = nums.Length / 4;
            int[] sum = new int[2 * length];
            int[] tempNums = new int[2 * length];

            for (int i = 0; i < 2 * length; i++)
            {
                sum[i] = nums[length + i];
            }

            for (int i = 0; i < length; i++)
            {
                tempNums[i] = nums[i];
                tempNums[length + i] = nums[3 * length + i];
            }

            ReverseStartEnd(tempNums, 2 * length);

            for (int i = 0; i < 2 * length; i++)
            {
                sum[i] = sum[i] + tempNums[i];
                Console.Write($"{sum[i]} ");
            }
        }

        static void ReverseStartEnd(int[] tempNums, int length)
        {
            for (int i = 0; i < length / 4; i++)
            {
                int tempNum = 0;
                tempNum = tempNums[i];
                tempNums[i] = tempNums[length / 2 - 1 - i];
                tempNums[length / 2 - 1 - i] = tempNum;

                tempNum = tempNums[length / 2 + i];
                tempNums[length / 2 + i] = tempNums[length - 1 - i];
                tempNums[length - 1 - i] = tempNum;
            }
        }

    }
}
