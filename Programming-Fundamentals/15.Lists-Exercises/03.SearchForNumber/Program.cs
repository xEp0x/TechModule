using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.SearchForNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            const char delimiter = ' ';

            List<int> nums = Console.ReadLine().Split(delimiter).Select(int.Parse).ToList();
            int[] manipulate = Console.ReadLine().Split(delimiter).Select(int.Parse).ToArray();

            int numsCountToTake = manipulate[0];
            int numsForDeletionFromTaken = manipulate[1];
            int numForSearch = manipulate[2];

            List<int> tempList = nums.GetRange(0, numsCountToTake);
            tempList.RemoveRange(0, numsForDeletionFromTaken);
            bool isInList = tempList.Contains(numForSearch);

            if (isInList)
            {
                Console.WriteLine("YES!");
            }
            else
            {
                Console.WriteLine("NO!");
            }

        }
    }
}
