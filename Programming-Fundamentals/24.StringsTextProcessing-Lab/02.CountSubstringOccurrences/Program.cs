using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.CountSubstringOccurrences
{
    class CountSubstringOccurrences
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine().ToLower();
            var searchedText = Console.ReadLine().ToLower();

            var count = 0;
            var index = 0;

            while (true)
            {
                index = text.IndexOf(searchedText, index);
                if (index >= 0)
                {
                    count++;
                    index++;
                }
                else
                {                   
                    break;
                }
            }

            Console.WriteLine(count);
        }
    }
}
