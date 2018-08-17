using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.SumMinMaxAverage
{
    class Program
    {
        static void Main(string[] args)
        {
            int numsCount = int.Parse(Console.ReadLine());
            List<int> nums = new List<int>();

            for (int i = 0; i < numsCount; i++)
            {
                int currentNum = int.Parse(Console.ReadLine());
                nums.Add(currentNum);
            }

            long sumNums = nums.Sum();
            int minNum = nums.Min();
            int maxNum = nums.Max();
            double averageNum = nums.Average();

            Console.WriteLine($"Sum = {sumNums}\nMin = {minNum}\nMax = {maxNum}\nAverage = {averageNum}");
        }
    }
}
