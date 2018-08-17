using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.MaxSequence_IncreasingElements
{
    class Program
    {
        static void Main(string[] args)
        {
            const char delimiter = ' ';
            int[] nums = Console.ReadLine().Split(delimiter).Select(int.Parse).ToArray();

            int startIndex = 0;
            int length = 1;

            int maxLengthIndex = 0;
            int maxLength = 0;

            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] > nums[i - 1])
                {
                    length++;
                    if (length > maxLength)
                    {
                        maxLength = length;
                        maxLengthIndex = startIndex;
                    }
                }
                else
                {
                    startIndex = i;
                    length = 1;
                }
            }

            for (int i = maxLengthIndex; i < maxLengthIndex + maxLength; i++)
            {
                Console.Write(nums[i] + " ");
            }

            Console.WriteLine();
        }
    }
}
