using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.ManipulateArray
{
    class Program
    {
        //public static string[] stringArr;
        static void Main(string[] args)
        {
            const char delimiter = ' ';

            string[] stringArr = Console.ReadLine().Split(delimiter).ToArray();
            int commandCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < commandCount; i++)
            {
                string[] command = Console.ReadLine().Split(delimiter).ToArray();

                switch (command[0])
                {
                    case "Reverse":
                        ReverseString(stringArr);
                        //Console.WriteLine(string.Join(" ", stringArr));
                        break;
                    case "Distinct":
                        stringArr = DistinctString(stringArr);
                        //Console.WriteLine(string.Join(" ", stringArr));
                        break;
                    case "Replace":
                        ReplaceElement(stringArr, command);
                        //Console.WriteLine(string.Join(" ", stringArr));
                        break;
                    default:
                        Console.WriteLine("No such command");
                        break;
                }
            }

            Console.WriteLine(string.Join(", ", stringArr));
        }

        static void ReplaceElement(string[] stringArr, string[] command)
        {
            stringArr[int.Parse(command[1])] = command[2];
        }

        static string[] DistinctString(string[] stringArr)
        {

            stringArr = stringArr.Distinct().ToArray();

            return stringArr;
        }

        static void ReverseString(string[] stringArr)
        {
            for (int i = 0; i < stringArr.Length / 2; i++)
            {
                string tempStr = string.Empty;
                tempStr = stringArr[i];
                stringArr[i] = stringArr[stringArr.Length - 1 - i];
                stringArr[stringArr.Length - 1 - i] = tempStr;
            }
        }
    }
}
