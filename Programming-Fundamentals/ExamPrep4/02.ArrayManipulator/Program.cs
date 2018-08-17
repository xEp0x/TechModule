using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.ArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            var inputLine = Console.ReadLine();

            while (inputLine != "end")
            {
                var commands = inputLine.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var command = commands.First();

                if (command == "exchange")
                {
                    var length = nums.Count;
                    var index = int.Parse(commands.Last());
                    var isIndexValid = ValidateIndex(index, length);

                    if (!isIndexValid)
                    {
                        Console.WriteLine("Invalid index");
                        inputLine = Console.ReadLine();
                        continue;
                    }

                    ExchangeNums(nums, index);
                    //Console.WriteLine("[" + string.Join(", ", nums) + "]");
                }
                else if (command == "max")
                {
                    var whatNumType = commands[1];

                    if (whatNumType == "odd")
                    {
                        var allOdd = nums.Where(n => n % 2 == 1).ToList();
                        var index = allOdd.Count == 0 ? -1 : nums.LastIndexOf(allOdd.Max());                        
                        Console.WriteLine(index == -1 ? "No matches" : $"{index}");                        
                    }
                    else
                    {
                        var allEven = nums.Where(n => n % 2 == 0).ToList();
                        var index = allEven.Count == 0 ? -1 : nums.LastIndexOf(allEven.Max());
                        Console.WriteLine(index == -1 ? "No matches" : $"{index}");
                    }

                }
                else if (command == "min")
                {
                    var whatNumType = commands[1];

                    if (whatNumType == "odd")
                    {
                        var minOdd = nums.Where(n => n % 2 == 1).ToList();
                        var index = minOdd.Count == 0 ? -1 : nums.LastIndexOf(minOdd.Min());
                        Console.WriteLine(index == -1 ? "No matches" : $"{index}");
                    }
                    else
                    {
                        var minEven = nums.Where(n => n % 2 == 0).ToList();
                        var index = minEven.Count == 0 ? -1 : nums.LastIndexOf(minEven.Min());
                        Console.WriteLine(index == -1 ? "No matches" : $"{index}");
                    }
                }
                else if (command == "first")
                {
                    var count = int.Parse(commands[1]);
                    var whatNumType = commands[2];
                    var length = nums.Count;
                    var isCountValid = ValidateIndex(count, length + 1);

                    if (!isCountValid)
                    {
                        Console.WriteLine("Invalid count");
                        inputLine = Console.ReadLine();
                        continue;
                    }

                    if (whatNumType == "odd")
                    {
                        var allOdd = nums.Where(n => n % 2 == 1).ToList();
                        Console.WriteLine(allOdd.Count == 0 ? "[]" : "[" + string.Join(", ", allOdd.Take(count)) + "]");
                    }
                    else
                    {
                        var allEven = nums.Where(n => n % 2 == 0).ToList();
                        Console.WriteLine(allEven.Count == 0 ? "[]" : "[" + string.Join(", ", allEven.Take(count)) + "]");
                    }


                }
                else if (command == "last")
                {
                    var count = int.Parse(commands[1]);
                    var whatNumType = commands[2];
                    var length = nums.Count;
                    var isCountValid = ValidateIndex(count, length + 1);

                    if (!isCountValid)
                    {
                        Console.WriteLine("Invalid count");
                        inputLine = Console.ReadLine();
                        continue;
                    }

                    if (whatNumType == "odd")
                    {
                        var allOdd = nums.Where(n => n % 2 == 1).ToList();
                        Console.WriteLine(allOdd.Count == 0 ? "[]" : "[" + string.Join(", ", allOdd.Skip(allOdd.Count - count)) + "]");
                    }
                    else
                    {
                        var allEven = nums.Where(n => n % 2 == 0).ToList();

                        Console.WriteLine(allEven.Count == 0 ? "[]" : "[" + string.Join(", ", allEven.Skip(allEven.Count - count)) + "]");
                    }

                }
                else
                {
                    Console.WriteLine("No such command!");
                }

                inputLine = Console.ReadLine();
            }

            Console.WriteLine("[" + string.Join(", ", nums) + "]");
        }

        static bool ValidateIndex(int index, int length)
        {
            if (index >= 0 && index < length)
            {
                return true;
            }

            return false;
        }

        static void ExchangeNums(List<int> nums, int index)
        {
            var firstNumsList = nums.Take(index + 1).ToList();
            nums.RemoveRange(0, index + 1);
            nums.AddRange(firstNumsList);
        }
    }
}
