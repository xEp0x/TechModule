using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11._5DifferentNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            string str = string.Empty;
            int diff = Math.Abs(num1 - num2);

            if (diff < 5)
            {
                Console.WriteLine("No");
                return;
            }

            for (int i = num1; i <= num2; i++)
            {
                for (int j = num1; j <= num2; j++)
                {
                    for (int k = num1; k <= num2; k++)
                    {
                        for (int l = num1; l <= num2; l++)
                        {
                            for (int m = num1; m <= num2; m++)
                            {
                                if (i < j && j < k && k < l && l < m)
                                {
                                    str = "" + i + " " + j + " " + k + " " + l + " " + m;
                                    Console.WriteLine(str);
                                }                                
                            }
                        }
                    }
                }
            }
        }
    }
}
