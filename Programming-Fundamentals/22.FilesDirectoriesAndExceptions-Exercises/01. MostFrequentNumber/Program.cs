using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;

namespace _01.MostFrequentNumber
{
    class Program
    {
        static void Main(string[] args)
        {

            GenerateFileWithRandomNumbers();

            string[] fileLines = File.ReadAllLines(@"input.txt");
            List<int> numMaxOccurance = new List<int>();
            List<int> maxOccurance = new List<int>();

            CalcMaxNumAndOccurance(fileLines, numMaxOccurance, maxOccurance);

            WriteInfoToFile(fileLines, numMaxOccurance, maxOccurance);
        }

        private static void WriteInfoToFile(string[] fileLines, List<int> numMaxOccurance, List<int> maxOccurance)
        {
            File.WriteAllText(@"output.txt", string.Empty);
            for (int i = 0; i < fileLines.Length; i++)
            {
                StringBuilder sb = new StringBuilder();
                sb.Append(fileLines[i]);
                sb.Append("  -->  ");
                sb.Append($"Leftmost frequent number is {numMaxOccurance[i]}. It occurs {maxOccurance[i]} times.");
                File.AppendAllText(@"output.txt", sb.ToString() + "\n");
            }
        }

        private static void CalcMaxNumAndOccurance(string[] fileLines, List<int> numMaxOccurance, List<int> maxOccurance)
        {
            foreach (var line in fileLines)
            {
                var nums = line.Split().Select(int.Parse).ToArray();

                int maxOccurrence = 0;
                int maxNumber = 0;

                for (int i = 0; i < nums.Length; i++)
                {
                    int occurrence = 0;

                    for (int j = i; j < nums.Length; j++)
                    {
                        if (nums[i] == nums[j])
                        {
                            occurrence++;

                        }
                        if (occurrence > maxOccurrence)
                        {
                            maxOccurrence = occurrence;
                            maxNumber = nums[i];
                        }
                    }
                }

                numMaxOccurance.Add(maxNumber);
                maxOccurance.Add(maxOccurrence);
            }
        }

        private static void GenerateFileWithRandomNumbers()
        {

            File.WriteAllText(@"input.txt", string.Empty);
            Random rnd = new Random();

            for (int j = 0; j < 10; j++)
            {
                List<int> numbers = new List<int>();
                for (int i = 0; i < 10; i++)
                {
                    var number = rnd.Next(1, 11);
                    numbers.Add(number);
                }
                File.AppendAllText(@"input.txt", string.Join(" ", numbers) + "\n");
            }
        }
    }
}
