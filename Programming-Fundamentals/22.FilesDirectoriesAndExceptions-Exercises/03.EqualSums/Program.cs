using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace _03.EqualSums
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
                long leftSum = 0;
                long rightSum = 0;
                int index = -1;

                for (int i = 0; i < nums.Length; i++)
                {
                    for (int j = 0; j < i; j++)
                    {
                        leftSum += nums[j];
                    }

                    for (int k = i + 1; k < nums.Length; k++)
                    {
                        rightSum += nums[k];
                    }

                    if (leftSum == rightSum)
                    {
                        index = i;
                    }
                    else
                    {
                        leftSum = 0;
                        rightSum = 0;
                    }
                }

                StringBuilder sb = new StringBuilder();

                if (line.Length == 1)
                {
                    sb.Append(line);
                    sb.Append("  -->  0");
                    File.AppendAllText(@"output.txt", sb.ToString() + "\n");
                }
                else if ((leftSum == rightSum) && index == -1)
                {
                    sb.Append(line);
                    sb.Append("  -->  no");
                    File.AppendAllText(@"output.txt", sb.ToString() + "\n");
                }
                else
                {
                    sb.Append(line);
                    sb.Append($"  -->  {index}");
                    File.AppendAllText(@"output.txt", sb.ToString() + "\n");
                }
            }
        }
    }
}
