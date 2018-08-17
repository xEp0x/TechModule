using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.LongestIncreasingSubsequence_LIS_
{
    class Program
    {
        static void Main(string[] args)
        {
            const char delimiter = ' ';

            int[] nums = Console.ReadLine().Split(delimiter).Select(int.Parse).ToArray();
            int[] len = new int[nums.Length];
            int[] previousPosition = new int[nums.Length];

            int maxLen = 0;
            int lastIndex = -1;

            for (int index = 0; index < nums.Length; index++)
            {
                len[index] = 1;
                previousPosition[index] = -1;

                for (int i = 0; i <= index - 1; i++)
                {
                    if (nums[i] < nums[index] && (len[i] + 1) > len[index])
                    {
                        len[index] = 1 + len[i];
                        previousPosition[index] = i;
                    }

                    if (len[index] > maxLen)
                    {
                        maxLen = len[index];
                        lastIndex = index;
                    }
                }
            }

            List<int> lis = new List<int>();

            if (nums.Length == 1)
            {
                lis.Add(nums[0]);
            }
            else
            {
                while (lastIndex != -1)
                {
                    lis.Add(nums[lastIndex]);
                    lastIndex = previousPosition[lastIndex];
                }
            }

            lis.Reverse();

            Console.WriteLine(string.Join(" ", lis));
        }
    }
}
