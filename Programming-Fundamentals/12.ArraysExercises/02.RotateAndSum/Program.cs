using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.RotateAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            const char delimiter = ' ';

            int[] nums = Console.ReadLine().Split(delimiter).Select(int.Parse).ToArray();
            int rotationCount = int.Parse(Console.ReadLine());
            int[] sum = new int[nums.Length];

            for (int i = 0; i < rotationCount; i++)
            {
                ArrayShiftRight(nums);
                for (int j = 0; j < nums.Length; j++)
                {
                    sum[j] = sum[j] + nums[j];
                }
            }

            for (int i = 0; i < sum.Length; i++)
            {
                Console.Write($"{sum[i]} ");
            }

        }

        static void ArrayShiftRight(int[] array)
        {
            int lastMember = array[array.Length - 1];

            for (int i = array.Length - 1; i > 0; i--)
            {
                array[i] = array[i - 1];
            }
            array[0] = lastMember;
        }

    }
}
