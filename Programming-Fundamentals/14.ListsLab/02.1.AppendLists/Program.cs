using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02._1.AppendLists
{
    class Program
    {
        static void Main(string[] args)
        {
            const char delimiter = '|';

            List<string> numStrings = Console.ReadLine().Split(delimiter).ToList();

            for (int i = 0; i < numStrings.Count; i++)
            {
                List<int> nums = numStrings[i].Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
                numStrings[i] = string.Join(" ", nums);
            }

            numStrings.Reverse();

            Console.WriteLine(string.Join(" ", numStrings));
        }
    }
}
