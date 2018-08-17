using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.EqualSums
{
    class Program
    {
        static void Main(string[] args)
        {
            const char delimiter = ' ';

            int[] nums = Console.ReadLine().Split(delimiter).Select(int.Parse).ToArray();
            long leftSum = 0;
            long rightSum = 0;
            int index = -1;

            for (int i = 0; i < nums.Length ; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    leftSum += nums[j];
                }

                for (int k = i + 1; k < nums.Length; k++)
                {
                    rightSum += nums[k];
                }

                if (leftSum == rightSum)
                {
                    index = i;
                }
                else
                {
                    leftSum = 0;
                    rightSum = 0;
                }
            }

            if (nums.Length == 1)
            {
                Console.WriteLine(0);
            }
            else if ((leftSum == rightSum) && index == -1)
            {
                Console.WriteLine("no");
            }
            else
            {
                Console.WriteLine(index);
            }

        }
    }
}
