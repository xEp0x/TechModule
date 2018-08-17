using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.LargestCommonEnd
{
    class Program
    {
        static void Main(string[] args)
        {
            const char delimiter = ' ';

            string[] firstArr = Console.ReadLine().Split(delimiter).ToArray();
            string[] secondArr = Console.ReadLine().Split(delimiter).ToArray();
            int minLength = Math.Min(firstArr.Length, secondArr.Length);
            int counterLeftToEnd = 0;
            int counterRightToBegin = 0;

            for (int i = 0; i < minLength; i++)
            {
                if (firstArr[i].Equals(secondArr[i]))
                {
                    counterLeftToEnd++;
                }
            }

            int difLength = Math.Abs(firstArr.Length - secondArr.Length);

            if (firstArr.Length > secondArr.Length)
            {
                for (int i = minLength - 1; i >= 0; i--)
                {
                    if (firstArr[i + difLength].Equals(secondArr[i]))
                    {
                        counterRightToBegin++;
                    }
                }
            }
            else
            {
                for (int i = minLength - 1; i >= 0; i--)
                {
                    if (firstArr[i].Equals(secondArr[i + difLength]))
                    {
                        counterRightToBegin++;
                    }
                }
            }

            if (counterLeftToEnd == 0 && counterRightToBegin == 0)
            {
                Console.WriteLine(counterLeftToEnd);
            }
            else if (counterLeftToEnd >= counterRightToBegin)
            {
                Console.WriteLine(counterLeftToEnd);
            }
            else
            {
                Console.WriteLine(counterRightToBegin);
            }

        }
    }
}
