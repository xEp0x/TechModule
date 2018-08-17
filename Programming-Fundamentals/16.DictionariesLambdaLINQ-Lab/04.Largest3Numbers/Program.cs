using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Largest3Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();

            //List<int> largestThree = nums.OrderByDescending(num => num).Take(3).ToList();  //order numbers 

            List<int> largestThree = nums.OrderBy(num => num).ToList();          //
            largestThree.Reverse();                                              // other way to order the numbers
            largestThree = largestThree.Take(3).ToList();                        //

            Console.WriteLine(string.Join(" ", largestThree));
        }
    }
}
