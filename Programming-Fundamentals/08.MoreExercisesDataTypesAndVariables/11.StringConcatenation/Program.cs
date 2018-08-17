using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.StringConcatenation
{
    class Program
    {
        static void Main(string[] args)
        {
            char delimiter = char.Parse(Console.ReadLine());
            string oddEven = Console.ReadLine().ToLower().Trim();
            int stringsCount = int.Parse(Console.ReadLine());
            string concatenatedString = string.Empty;

            if (oddEven == "odd")
            {
                for (int i = 1; i <= stringsCount; i++)
                {
                    string enteredString = Console.ReadLine();

                    if (i % 2 == 1)
                    {
                        concatenatedString += enteredString + delimiter;
                    }
                }

            }
            else
            {
                for (int i = 1; i <= stringsCount; i++)
                {
                    string enteredString = Console.ReadLine();

                    if (i % 2 == 0)
                    {
                        concatenatedString += enteredString + delimiter;
                    }
                }
            }

            Console.WriteLine(concatenatedString.Remove(concatenatedString.Length-1));

        }
    }
}
