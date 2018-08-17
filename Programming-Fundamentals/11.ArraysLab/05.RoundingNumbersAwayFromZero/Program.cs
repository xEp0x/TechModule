using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.RoundingNumbersAwayFromZero
{
    class Program
    {
        static void Main(string[] args)
        {
            const char delimeter = ' ';

            string[] inputNumbers = Console.ReadLine().Split(delimeter).ToArray();
            double[] nums = new double[inputNumbers.Length];

            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = double.Parse(inputNumbers[i]);
            }

            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = Math.Round(nums[i], MidpointRounding.AwayFromZero);
                Console.WriteLine($"{inputNumbers[i]} => {nums[i]}");
            }        
        }
    }
}
