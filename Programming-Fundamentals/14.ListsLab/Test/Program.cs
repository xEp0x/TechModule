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
            const char delimiter = ' ';

            List<int> nums = Console.ReadLine().Split(delimiter).Select(int.Parse).ToList();
            //List<int> counts = new List<int>();
            int count = 1;
            nums.Sort();

            int previousNum = nums[0];

            for (int i = 1; i < nums.Count; i++)
            {
                int currentNum = nums[i];

                if (previousNum == currentNum)
                {
                    count++;
                    continue;
                }

                Console.WriteLine($"{previousNum} -> {count}");
                previousNum = currentNum;
                count = 1;
            }

            Console.WriteLine($"{previousNum} -> {count}");
        }
    }
}