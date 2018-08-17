using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Ladybugs
{
    class Ladybugs
    {
        static void Main(string[] args)
        {
            var fieldSize = int.Parse(Console.ReadLine());
            var bugIndexes = Console.ReadLine().Split().Select(int.Parse).ToList();
            int[] bugs = new int[fieldSize];

            foreach (var index in bugIndexes)
            {
                if (0 <= index && index < bugs.Length)
                {
                    bugs[index] = 1;
                }
            }

            var inputLine = Console.ReadLine();

            while (inputLine != "end")
            {
                var command = inputLine.Split();
                var bugIndex = int.Parse(command[0]);
                var direction = command[1];
                var flyLength = int.Parse(command[2]);

                if (bugIndex < 0 || bugIndex >= bugs.Length)
                {
                    inputLine = Console.ReadLine();
                    continue;
                }

                if (bugs[bugIndex] == 0 || bugIndex < 0 || bugIndex >= bugs.Length)
                {
                    inputLine = Console.ReadLine();
                    continue;
                }

                if (direction == "right")
                {
                    bugs[bugIndex] = 0;
                    bugIndex += flyLength;

                    if (bugIndex < 0 || bugIndex >= bugs.Length)
                    {
                        inputLine = Console.ReadLine();
                        continue;
                    }

                    while (bugs[bugIndex] == 1)
                    {
                        bugIndex += flyLength;

                        if (bugIndex < 0 || bugIndex >= bugs.Length)
                        {
                            break;
                        }
                    }

                    if (bugIndex < 0 || bugIndex >= bugs.Length)
                    {
                        inputLine = Console.ReadLine();
                        continue;
                    }

                    bugs[bugIndex] = 1;
                }
                else if (direction == "left")
                {
                    bugs[bugIndex] = 0;
                    bugIndex -= flyLength;

                    if (bugIndex < 0 || bugIndex >= bugs.Length)
                    {
                        inputLine = Console.ReadLine();
                        continue;
                    }

                    while (bugs[bugIndex] == 1)
                    {
                        bugIndex -= flyLength;

                        if (bugIndex < 0 || bugIndex >= bugs.Length)
                        {
                            break;
                        }
                    }

                    if (bugIndex < 0 || bugIndex >= bugs.Length)
                    {
                        inputLine = Console.ReadLine();
                        continue;
                    }

                    bugs[bugIndex] = 1;
                }
                else
                {
                    Console.WriteLine("No such direction!");
                }

                inputLine = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", bugs));
        }
    }
}
