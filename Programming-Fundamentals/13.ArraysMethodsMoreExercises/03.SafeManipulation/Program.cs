using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.SafeManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            const char delimiter = ' ';

            string[] stringArr = Console.ReadLine().Split(delimiter).ToArray();
            string[] command = Console.ReadLine().Split(delimiter).ToArray();

            while (command[0] != "END")
            {
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
                        Console.WriteLine("Invalid input!");
                        break;
                }
                command = Console.ReadLine().Split(delimiter).ToArray();
            }

            Console.WriteLine(string.Join(", ", stringArr));
        }

        static void ReplaceElement(string[] stringArr, string[] command)
        {
            int index = int.Parse(command[1]);
            bool isIndexCorrect = index >= 0 && index < stringArr.Length;
            if (isIndexCorrect)
            {
                stringArr[index] = command[2];
            }
            else
            {
                Console.WriteLine("Invalid input!");
            }
            
        }

        static string[] DistinctString(string[] stringArr)
        {

            stringArr = stringArr.Distinct().ToArray();

            return stringArr;
        }

        static void ReverseString(string[] stringArr)
        {
            Array.Reverse(stringArr);
        }
    }
}
