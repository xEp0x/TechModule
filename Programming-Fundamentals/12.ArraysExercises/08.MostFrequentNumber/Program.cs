using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.MostFrequentNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            const char delimiter = ' ';
            int[] nums = Console.ReadLine().Split(delimiter).Select(int.Parse).ToArray();

            int maxOccurrence = 0;
            int maxNumber = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                int occurrence = 0;

                for (int j = i; j < nums.Length; j++)
                {
                    if (nums[i] == nums[j])
                    {
                        occurrence++;

                    }
                    if (occurrence > maxOccurrence)
                    {
                        maxOccurrence = occurrence;
                        maxNumber = nums[i];
                    }
                }
            }

            Console.WriteLine(maxNumber);
            //Console.WriteLine(maxOccurrence);
        }
    }
}
