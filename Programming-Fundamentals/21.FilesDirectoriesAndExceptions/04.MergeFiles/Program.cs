using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace _04.MergeFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstFileLines = File.ReadAllLines(@"c:\temp\input41.txt");
            string[] secondFileLines = File.ReadAllLines(@"c:\temp\input42.txt");
            var lengthMin = Math.Min(firstFileLines.Length, secondFileLines.Length);

            for (int i = 0; i < lengthMin; i++)
            {
                File.AppendAllText(@"c:\temp\output4.txt", firstFileLines[i] + "\n");
                File.AppendAllText(@"c:\temp\output4.txt", secondFileLines[i] + "\n");
            }

            if (firstFileLines.Length > secondFileLines.Length)
            {

                File.AppendAllLines(@"c:\temp\output4.txt", firstFileLines.Skip(lengthMin));

             // for (int i = lengthMin; i < lengthMax; i++)
             // {
             //     File.AppendAllText(@"c:\temp\output4.txt", firstFileLines[i] + "\n");
             // }
            }
            else
            {
                File.AppendAllLines(@"c:\temp\output4.txt", secondFileLines.Skip(lengthMin));

             // for (int i = lengthMin; i < lengthMax; i++)
             // {
             //     File.AppendAllText(@"c:\temp\output4.txt", secondFileLines[i] + "\n");
             // }
            }

        }
    }
}
