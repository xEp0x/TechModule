using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace _05.WriteToFile
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] punctuationMarks = new char[] { '.', ',', '!', '?', ':' };

            var fileText = File.ReadAllText(@"sample_text.txt");

            foreach (var punctMark in punctuationMarks)
            {
                string str = punctMark.ToString();
                fileText = fileText.Replace(str, "");
            }

            File.WriteAllText(@"output.txt", string.Empty);
            File.WriteAllText(@"output.txt", string.Join(" ", fileText));
        }
    }
}
