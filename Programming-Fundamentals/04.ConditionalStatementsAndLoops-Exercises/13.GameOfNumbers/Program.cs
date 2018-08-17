using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.GameOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int magicNum = int.Parse(Console.ReadLine());
            int sum = 0;
            int counter = 0;

            for (int i = num2; i >= num1; i--)
            {
                for (int j = num2; j >= num1; j--)
                {
                    counter++;
                    sum = i + j;                    
                    if (sum == magicNum)
                    {
                        Console.WriteLine($"Number found! {i} + {j} = {sum}");
                        return;
                    }
                }
            }

            Console.WriteLine($"{counter} combinations - neither equals {magicNum}");

        }
    }
}
