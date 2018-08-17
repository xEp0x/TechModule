using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.FoldAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();
            int length = nums.Count / 4;

            List<int> row1Left = nums.Take(length).ToList();
            row1Left.Reverse();

            List<int> row1Right = nums.Skip(3 * length).Take(length).ToList();
            row1Right.Reverse();

            List<int> row1 = row1Left.Concat(row1Right).ToList();
            List<int> row2 = nums.Skip(length).Take(2 * length).ToList();

            List<int> sumNums = new List<int>();

            sumNums = row1.Select((num, index) => num + row2[index]).ToList();

            //   for (int i = 0; i < 2 * length; i++)
            //   {
            //       int sum = 0;
            //       sum = row1[i] + row2[i];
            //       sumNums.Add(sum);
            //   }

            Console.WriteLine(string.Join(" ", sumNums));
        }
    }
}
