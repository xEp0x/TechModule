using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace _04.PunctuationFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] punctuationMarks = new char[] { '.', ',', '!', '?', ':', };

            var fileText = File.ReadAllText(@"sample_text.txt").ToCharArray();
            List<char> punctMarks = new List<char>();

            foreach (var ch in fileText)
            {
                if (punctuationMarks.Contains(ch))
                {
                    punctMarks.Add(ch);
                }
            }

            File.WriteAllText(@"output.txt", string.Empty);
            File.WriteAllText(@"output.txt", string.Join(", ", punctMarks));
        }
    }
}
