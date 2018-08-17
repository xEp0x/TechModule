using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.TripleSum
{
    class Program
    {
        static void Main(string[] args)
        {
            const char delimeter = ' ';

            string[] inputNumbers = Console.ReadLine().Split(delimeter).ToArray();
            int[] nums = new int[inputNumbers.Length];

            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = int.Parse(inputNumbers[i]);
            }

            int sum = 0;
            bool isSum = false;

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    sum = nums[i] + nums[j];

                    if (nums.Contains(sum))
                    {
                        Console.WriteLine($"{nums[i]} + {nums[j]} == {sum}");
                        isSum = true;
                    }

                }
            }

            if (!isSum)
            {
                Console.WriteLine("No");
            }

        }
    }
}
