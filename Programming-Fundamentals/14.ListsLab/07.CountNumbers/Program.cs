using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.CountNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            const char delimiter = ' ';

            List<int> nums = Console.ReadLine().Split(delimiter).Select(int.Parse).ToList();
            List<int> counts = new List<int>();
            int count = 1;
            nums.Sort();

            for (int i = 0; i < nums.Count - 1; i++)
            {
                for (int j = i + 1; j < nums.Count; j++)
                {
                    if (nums[i] == nums[j])
                    {
                        count++;
                    }
                }
                Console.WriteLine($"{nums[i]} -> {count}");
                i = i + count - 1;
                count = 1;
            }
        }
    }
}
