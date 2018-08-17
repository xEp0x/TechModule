using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.CountRealNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<double, int> realNumsCount = new SortedDictionary<double, int>();
            List<double> nums = Console.ReadLine().Split(' ').Select(double.Parse).ToList();

            foreach (var num in nums)
            {
                if (realNumsCount.ContainsKey(num))
                {
                    realNumsCount[num]++;
                }
                else
                {
                    realNumsCount[num] = 1;
                }
            }

            foreach (var element in realNumsCount)
            {
                Console.WriteLine($"{element.Key} -> {element.Value}");
            }
        }
    }
}
