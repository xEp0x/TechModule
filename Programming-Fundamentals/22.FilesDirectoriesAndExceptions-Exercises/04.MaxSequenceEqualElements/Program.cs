using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace _04.MaxSequenceEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] fileLines = File.ReadAllLines(@"input.txt");
            File.WriteAllText(@"output.txt", string.Empty);

            foreach (var line in fileLines)
            {
                int[] nums = line.Split().Select(int.Parse).ToArray();

                int startIndex = 0;
                int length = 1;

                int maxLengthIndex = 0;
                int maxLength = 0;

                for (int i = 1; i < nums.Length; i++)
                {
                    if (nums[i] == nums[i - 1])
                    {
                        length++;
                        if (length > maxLength)
                        {
                            maxLength = length;
                            maxLengthIndex = startIndex;
                        }
                    }
                    else
                    {
                        startIndex = i;
                        length = 1;
                    }
                }

                List<int> numMaxLength = new List<int>();
                for (int i = maxLengthIndex; i < maxLengthIndex + maxLength; i++)
                {
                    numMaxLength.Add(nums[i]);
                }

                StringBuilder sb = new StringBuilder();
                sb.Append(line);
                sb.Append("   --->   ");
                sb.Append(string.Join(" ", numMaxLength));

                File.AppendAllText(@"output.txt", sb.ToString() + "\n");
            }
        }
    }
}
