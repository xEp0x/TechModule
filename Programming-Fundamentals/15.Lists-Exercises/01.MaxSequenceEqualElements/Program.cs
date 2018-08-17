using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.MaxSequenceEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            const char delimiter = ' ';

            List<int> nums = Console.ReadLine().Split(delimiter).Select(int.Parse).ToList();

            int previousNum = nums[0];
            int count = 1;

            int numMaxSequence = nums[0];
            int maxSequence = 1;

            for (int i = 1; i < nums.Count; i++)
            {
                int currentNum = nums[i];
                if (previousNum == currentNum)
                {
                    count++;
                    if (count > maxSequence)
                    {
                        maxSequence = count;
                        numMaxSequence = currentNum;
                    }
                }
                else
                {
                    previousNum = currentNum;
                    count = 1;
                }
            }

            for (int i = 0; i < maxSequence; i++)
            {
                Console.Write($"{numMaxSequence} ");
            }                            
        }
    }
}
