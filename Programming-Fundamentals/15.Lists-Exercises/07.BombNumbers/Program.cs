using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.BombNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            const char delimiter = ' ';

            List<int> nums = Console.ReadLine().Split(delimiter).Select(int.Parse).ToList();
            List<int> bomb = Console.ReadLine().Split(delimiter).Select(int.Parse).ToList();

            int bombNumber = bomb[0];
            int bombPower = bomb[1];

            for (int i = 0; i < nums.Count; i++)
            {
                if (nums[i] == bombNumber)
                {
                    int leftRemove = 0;
                    int rightRemove = 0;

                    if (i >= bombPower)
                    {
                        leftRemove = bombPower;
                    }
                    else
                    {
                        leftRemove = Math.Max(i, 0);
                    }

                    if ((i + bombPower) >= nums.Count)
                    {
                        rightRemove = nums.Count - 1 - i;
                    }
                    else
                    {
                        rightRemove = bombPower;
                    }

                    int pos = i - leftRemove;
                    int countForRemove = leftRemove + 1 + rightRemove;

                    nums.RemoveRange(pos, countForRemove);
                    i = -1;
                }
            }

            long sum = 0;

            foreach (var element in nums)
            {
                sum += element;
            }

            Console.WriteLine(sum);
        }
    }
}
