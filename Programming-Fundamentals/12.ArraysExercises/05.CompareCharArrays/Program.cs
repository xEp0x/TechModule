using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.CompareCharArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            const char delimiter = ' ';

            char[] firstArr = Console.ReadLine().Split(delimiter).Select(char.Parse).ToArray();
            char[] secondArr = Console.ReadLine().Split(delimiter).Select(char.Parse).ToArray();
            string first = new string(firstArr);
            string second = new string(secondArr);
            bool isLonger = firstArr.Length > secondArr.Length;

            int firstLength = firstArr.Length;
            int secondLength = second.Length;

            if (firstArr.Length == secondArr.Length)
            {
                CompareCharArrays(firstArr, secondArr);
            }
            else if (isLonger)
            {
                CompareCharArrays(firstArr, secondArr);
            }
            else
            {
                CompareCharArrays(secondArr, firstArr);
            }

        }

        static void CompareCharArrays(char[] firstArr, char[] secondArr)
        {
            string first = new string(firstArr);
            string second = new string(secondArr);

            for (int i = 0; i < firstArr.Length; i++)
            {
                if (firstArr[i] < secondArr[i])
                {
                    Console.WriteLine(first);
                    Console.WriteLine(second);
                    return;
                }
                else
                {
                    Console.WriteLine(second);
                    Console.WriteLine(first);
                    return;
                }
            }
        }

    }
}
