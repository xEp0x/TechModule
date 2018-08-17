using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace _05.MinerTask
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] fileLines = File.ReadAllLines(@"input.txt");

            Dictionary<string, int> resources = new Dictionary<string, int>();

            for (int i = 0; i < fileLines.Length; i+=2)
            {                          
                if (fileLines[i] != "stop")
                {
                    string resource = fileLines[i];
                    int quantity = int.Parse(fileLines[i + 1]);

                    if (!resources.ContainsKey(resource))
                    {
                        resources[resource] = 0;
                    }

                    resources[resource] += quantity;
                }
                else
                {
                    break;
                }                
            }

            File.WriteAllText(@"output.txt", string.Empty);
            foreach (var resourceQuantity in resources)
            {
                var resource = resourceQuantity.Key;
                var quantity = resourceQuantity.Value;

                File.AppendAllText(@"output.txt", $"{resource} -> {quantity}\n");                
            }
        }
    }
}
