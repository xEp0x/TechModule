using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            const char delimeter = ' ';

            int[] nums = Console.ReadLine().Split(delimeter).Select(int.Parse).ToArray();                        

            if (nums.Length == 1)
            {
                Console.WriteLine(nums[0]);
                return;
            }

            while (nums.Length > 1)
            {
                int[] condensedNums = new int[nums.Length - 1];

                for (int i = 0; i < nums.Length - 1; i++)
                {
                    condensedNums[i] = nums[i] + nums[i + 1];
                }

                nums = condensedNums;
            }

            Console.WriteLine(nums[0]);
        }
    }
}
