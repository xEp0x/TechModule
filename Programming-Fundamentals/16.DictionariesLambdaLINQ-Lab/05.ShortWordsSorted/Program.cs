using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.ShortWordsSorted
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] delimiters = new char[] { ':', ',', ';', ':', '.', '!', '(', ')', '"', '\'', '\\', '/', '[', ']', ' ' };
            List<string> inputText = Console.ReadLine().ToLower().Split(delimiters, StringSplitOptions.RemoveEmptyEntries).ToList();

            List<string> words = inputText.Where(word => word.Length < 5).OrderBy(word => word).Distinct().ToList();

            Console.WriteLine(string.Join(", ", words));
        }
    }
}
