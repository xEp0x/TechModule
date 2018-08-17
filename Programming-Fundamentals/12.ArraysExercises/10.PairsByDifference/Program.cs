using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.PairsByDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            const char delimiter = ' ';
            int[] nums = Console.ReadLine().Split(delimiter).Select(int.Parse).ToArray();
            int diff = int.Parse(Console.ReadLine());
            int diffCounter = 0;

            for (int i = 0; i < nums.Length - 1; i++)
            {
                for (int j = i; j < nums.Length; j++)
                {
                    int currentDiff = Math.Abs(nums[i] - nums[j]);
                    bool isConcurrence = diff == currentDiff;

                    if (isConcurrence)
                    {
                        diffCounter++;
                    }
                }
            }

            Console.WriteLine(diffCounter);
        }
    }
}
