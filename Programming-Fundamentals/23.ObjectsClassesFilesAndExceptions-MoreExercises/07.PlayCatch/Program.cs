using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.PlayCatch
{
    class PlayCatch
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split().Select(int.Parse).ToList();
            var exceptionCount = 0;

            while (true)
            {
                if (exceptionCount >= 3)
                {
                    Console.WriteLine(string.Join(", ", nums));
                    return;
                }
                var commands = Console.ReadLine().Split();
                var command = commands[0];
                var manupulation = commands.Skip(1).Select(str => str).ToList();
                try
                {
                    switch (command)
                    {
                        case "Replace":
                            var index = int.Parse(manupulation[0]);
                            var element = int.Parse(manupulation[1]);
                            nums.RemoveAt(index);
                            nums.Insert(index, element);
                            break;
                        case "Print":
                            var startIndex = int.Parse(manupulation[0]);
                            var endIndex = int.Parse(manupulation[1]);
                            List<int> numsForPrint = new List<int>();
                            for (int i = startIndex; i <= endIndex; i++)
                            {
                                numsForPrint.Add(nums[i]);
                            }
                            Console.WriteLine(string.Join(", ", numsForPrint));
                            break;
                        case "Show":
                            index = int.Parse(manupulation[0]);
                            var num = nums[index];
                            Console.WriteLine(num);
                            break;
                        default:
                            Console.WriteLine("No such command!");
                            break;
                    }
                }
                catch (ArgumentOutOfRangeException)
                {
                    Console.WriteLine("The index does not exist!");
                    exceptionCount++;
                }
                catch (FormatException)
                {
                    Console.WriteLine("The variable is not in the correct format!");
                    exceptionCount++;
                }
            }
        }
    }
}
