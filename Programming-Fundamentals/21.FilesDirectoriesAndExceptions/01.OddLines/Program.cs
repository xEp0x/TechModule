using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;


namespace _01.OddLines
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines(@"c:\temp\input1.txt");

            string[] oddLines = lines.Where((line, index) => index % 2 == 1).ToArray();

            File.WriteAllLines(@"c:\temp\output1.txt", oddLines);
        }
    }
}
