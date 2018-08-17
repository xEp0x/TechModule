using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.SumAdjacentEqualNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            const char delimiter = ' ';

            List<double> nums = Console.ReadLine().Split(delimiter).Select(double.Parse).ToList();

            double previousNum = nums[0];
                    
            for (int i = 1; i < nums.Count; i++)
            {
                double currentNum = nums[i];

                if (currentNum == previousNum)
                {
                    double sum = currentNum + previousNum;
                    nums[i - 1] = sum;
                    nums[i] = sum;
                    nums.RemoveAt(i);                   
                    previousNum = nums[0];
                    i = 0;
                }
                else
                {
                    previousNum = nums[i];
                }
            }

            Console.WriteLine(string.Join(" ", nums));
        }
    }
}
