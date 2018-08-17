using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.CommandInterpreter
{
    class CommandInterpreter
    {
        static void Main(string[] args)
        {
            var inputStrings = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();

            while (true)
            {
                var inputLine = Console.ReadLine();

                if (inputLine == "end")
                {
                    break;
                }

                var commands = inputLine.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                var command = commands.First();
                var index = 0;
                var count = 0;

                if (commands.Length == 5)
                {
                    index = int.Parse(commands[2]);
                    count = int.Parse(commands[4]);



                    if (index < 0 || index >= inputStrings.Count)
                    {
                        Console.WriteLine("Invalid input parameters.");
                        continue;
                    }

                    if (count < 0 || count > inputStrings.Count)
                    {
                        Console.WriteLine("Invalid input parameters.");
                        continue;
                    }

                    if ((index + count) > inputStrings.Count)
                    {
                        Console.WriteLine("Invalid input parameters.");
                        continue;
                    }
                }
                else if (commands.Length == 2)
                {
                    count = int.Parse(commands[1]);

                    if (count < 0)
                    {
                        Console.WriteLine("Invalid input parameters.");
                        continue;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input parameters.");
                    continue;
                }

                var subListStrings = new List<string>();

                switch (command)
                {
                    case "reverse":
                        subListStrings = inputStrings.Skip(index).Take(count).ToList();

                        for (int i = 0; i < subListStrings.Count / 2; i++)
                        {
                            var tempStr = string.Empty;
                            tempStr = subListStrings[i];
                            subListStrings[i] = subListStrings[subListStrings.Count - 1 - i];
                            subListStrings[subListStrings.Count - 1 - i] = tempStr;
                        }

                        inputStrings.RemoveRange(index, count);
                        inputStrings.InsertRange(index, subListStrings);

                        break;
                    case "sort":
                        subListStrings = inputStrings.Skip(index).Take(count).ToList();
                        subListStrings.Sort();

                        inputStrings.RemoveRange(index, count);
                        inputStrings.InsertRange(index, subListStrings);

                        break;
                    case "rollLeft":

                        var rollCountL = count % inputStrings.Count;

                        for (int i = 0; i < rollCountL; i++)
                        {
                            inputStrings.Add(inputStrings[0]);
                            inputStrings.RemoveAt(0);
                        }

                        break;
                    case "rollRight":

                        var rollCountR = count % inputStrings.Count;

                        for (int i = 0; i < rollCountR; i++)
                        {
                            inputStrings.Insert(0, inputStrings.Last());
                            inputStrings.RemoveAt(inputStrings.Count - 1);
                        }

                        break;
                    default:
                        Console.WriteLine("Invalid input parameters.");
                        break;
                }
            }

            Console.WriteLine("[{0}]", String.Join(", ", inputStrings));
        }
    }
}
