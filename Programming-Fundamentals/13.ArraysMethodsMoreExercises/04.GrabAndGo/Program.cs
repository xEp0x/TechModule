using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.GrabAndGo
{
    class Program
    {
        static void Main(string[] args)
        {
            const char delimiter = ' ';

            int[] nums = Console.ReadLine().Split(delimiter).Select(int.Parse).ToArray();
            int checkNum = int.Parse(Console.ReadLine());
            int index = 0;

            for (int i = nums.Length - 1; i >= 0; i--)
            {
                if (nums[i] == checkNum)
                {
                    index = i;
                    break;
                }
            }

            long sum = 0;

            if (index == 0)
            {
                Console.WriteLine("No occurrences were found!");
            }
            else
            {
                for (int i = 0; i < index; i++)
                {
                    sum += nums[i];
                }
                Console.WriteLine(sum);
            }
        }
    }
}
