using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.OnlyLetters
{
    class OnlyLetters
    {
        static void Main(string[] args)
        {
            var inputLine = Console.ReadLine().ToList();
            var count = 0;

            for (int i = 0; i < inputLine.Count; i++)
            {
                var previousCh = inputLine[i];
                //var nextCh = inputLine[i + 1];

                if (char.IsDigit(previousCh))
                {
                    count++;
                }
                else
                {
                    if (count != 0)
                    {
                        inputLine.RemoveRange(i - count, count);
                        inputLine.Insert(i - count, previousCh);
                        count = 0;
                    }
                }
            }

            Console.WriteLine(string.Join("",inputLine));
        }
    }
}
