using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.SumArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            const char delimiter = ' ';

            int[] firstArr = Console.ReadLine().Split(delimiter).Select(int.Parse).ToArray();
            int[] secondArr = Console.ReadLine().Split(delimiter).Select(int.Parse).ToArray();

            int lengthTempArr = Math.Max(firstArr.Length, secondArr.Length);
            int[] tempArr = new int[lengthTempArr];

            if (firstArr.Length == secondArr.Length)
            {
                tempArr = CalcArraySum(firstArr, secondArr);
            }
            else if (firstArr.Length > secondArr.Length)
            {
                int counter = 0;
                for (int i = 0; i < tempArr.Length; i++)
                {
                    if (counter < secondArr.Length)
                    {
                        tempArr[i] = secondArr[counter];
                        counter++;
                    }
                    else
                    {
                        counter = 0;
                        i--;
                    }
                }
                tempArr = CalcArraySum(firstArr, tempArr);
            }
            else
            {
                int counter = 0;
                for (int i = 0; i < tempArr.Length; i++)
                {
                    if (counter < firstArr.Length)
                    {
                        tempArr[i] = firstArr[counter];
                        counter++;
                    }
                    else
                    {
                        counter = 0;
                        i--;
                    }
                }
                tempArr = CalcArraySum(secondArr, tempArr);
            }

            foreach (var item in tempArr)
            {
                Console.Write($"{item}" + " ");
            }

            Console.WriteLine();

        }

        static int[] CalcArraySum(int[] firstArr, int[] secondArr)
        {
            int[] sumArray = new int[firstArr.Length];

            for (int i = 0; i < sumArray.Length; i++)
            {
                sumArray[i] = firstArr[i] + secondArr[i];
            }

            return sumArray;
        }
    }
}
