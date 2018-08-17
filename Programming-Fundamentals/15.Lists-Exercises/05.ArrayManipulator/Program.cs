using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.ArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            const char delimiter = ' ';

            var nums = Console.ReadLine().Split(delimiter).Select(int.Parse).ToList();
            var line = Console.ReadLine().ToLower();
            int index = 0;
            int element = 0;

            while (line != "print")
            {
                var command = line.Split(delimiter);

                if (command[0] == "add")
                {
                    index = int.Parse(command[1]);
                    element = int.Parse(command[2]);
                    nums.Insert(index, element);
                }
                else if (command[0] == "addmany")
                {
                    index = int.Parse(command[1]);
                    List<int> elements = new List<int>();

                    for (int i = 2; i < command.Length; i++)
                    {
                        elements.Add(int.Parse(command[i]));
                    }

                    nums.InsertRange(index, elements);
                }
                else if (command[0] == "contains")
                {
                    element = int.Parse(command[1]);
                    index = nums.IndexOf(element);
                    Console.WriteLine(index);
                }
                else if (command[0] == "remove")
                {
                    index = int.Parse(command[1]);
                    nums.RemoveAt(index);
                }
                else if (command[0] == "shift")
                {
                    int position = int.Parse(command[1]);
                    int rotation = position % nums.Count;

                    for (int i = 0; i < rotation; i++)
                    {
                        nums.Add(nums[0]);
                        nums.RemoveAt(0);
                    }
                }
                else if (command[0] == "sumpairs")
                {
                    List<int> sumPair = new List<int>();

                    for (int i = 0; i < nums.Count; i += 2)
                    {
                        int currentNum = nums[i];
                        int nextNum = 0;

                        if (i < nums.Count - 1)
                        {
                            nextNum = nums[i + 1];
                        }
                        int sum = currentNum + nextNum;

                        sumPair.Add(sum);
                    }

                    nums = sumPair;
                }
                else
                {
                    Console.WriteLine("No such command");
                }

                line = Console.ReadLine().ToLower();
            }

            Console.WriteLine("[{0}]", string.Join(", ", nums));
        }
    }
}
