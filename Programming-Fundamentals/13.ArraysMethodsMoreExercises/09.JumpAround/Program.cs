using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.JumpAround
{
    class Program
    {
        static void Main(string[] args)
        {
            const char delimiter = ' ';

            int[] nums = Console.ReadLine().Split(delimiter).Select(int.Parse).ToArray();
            long sum = nums[0];
            int jump = nums[0];
            int index = 0;

            while (true)
            {
                if ((jump + index) < nums.Length)
                {
                    index += jump;
                    sum += nums[index];
                    jump = nums[index];
                }
                else if (index >= jump)
                {
                    index -= jump;
                    sum += nums[index];
                    jump = nums[index];
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine(sum);
        }
    }
}
