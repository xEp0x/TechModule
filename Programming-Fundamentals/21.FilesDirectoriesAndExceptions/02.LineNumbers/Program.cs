using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace _02.LineNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //string fullFilePath = Console.ReadLine();
            //string[] fileLines = File.ReadAllLines(fullFilePath);

            string[] fileLines = File.ReadAllLines(@"c:\temp\input2.txt");

            string[] fileLinesWithNumber = fileLines.Select((line, index) => line = "" + (index + 1) + ". " + line).ToArray();
            //better solution
            var numberedLines = fileLines.Select((line, index) => $"{index + 1}. {line}");
            
            File.WriteAllLines(@"c:\temp\output2.txt", fileLinesWithNumber);
        }
    }
}
