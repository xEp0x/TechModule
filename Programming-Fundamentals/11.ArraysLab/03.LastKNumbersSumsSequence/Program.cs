using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.LastKNumbersSumsSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int numCount = int.Parse(Console.ReadLine());
            int sumElementCount = int.Parse(Console.ReadLine());
            long[] elements = new long[numCount];
            elements[0] = 1;
            long sumElements = 0;

            for (int i = 1; i < numCount; i++)
            {
                int counter = 0;
                if (i < sumElementCount)
                {
                    counter = i;
                    for (int j = i - counter; j < counter; j++)
                    {
                        sumElements += elements[j];
                    }
                }
                else
                {
                    counter = sumElementCount;
                    for (int j = i - counter; j <= i - 1; j++)
                    {
                        sumElements += elements[j];
                    }
                }

                elements[i] = sumElements;
                sumElements = 0;
            }

            for (int i = 0; i < elements.Length; i++)
            {
                Console.Write($"{elements[i]}" + " ");
            }
        }
    }
}
