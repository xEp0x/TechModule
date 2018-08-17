using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _04.GUnit
{
    class Program
    {
        static void Main(string[] args)
        {
            var pattern = @"^(?<class>[A-Z][A-Za-z0-9]+) \| (?<method>[A-Z][A-Za-z0-9]+) \| (?<unit>[A-Z][A-Za-z0-9]+)$";
            Regex regex = new Regex(pattern);
            Dictionary<string, Dictionary<string, List<string>>> allClassMethodsAndUnits
                = new Dictionary<string, Dictionary<string, List<string>>>();

            while (true)
            {
                var inputLine = Console.ReadLine();

                if (inputLine == "It's testing time!")
                {
                    break;
                }

                Match inputMatch = regex.Match(inputLine);

                if (!inputMatch.Success)
                {
                    continue;
                }

                var custClass = inputMatch.Groups["class"].Value.Trim();
                var custMethod = inputMatch.Groups["method"].Value.Trim();
                var custUnit = inputMatch.Groups["unit"].Value.Trim();

                if (!allClassMethodsAndUnits.ContainsKey(custClass))
                {
                    allClassMethodsAndUnits[custClass] = new Dictionary<string, List<string>>();
                }

                if (!allClassMethodsAndUnits[custClass].ContainsKey(custMethod))
                {
                    allClassMethodsAndUnits[custClass][custMethod] = new List<string>();
                }

                if (!allClassMethodsAndUnits[custClass][custMethod].Contains(custUnit))
                {
                    allClassMethodsAndUnits[custClass][custMethod].Add(custUnit);
                }
                //Console.WriteLine();
            }

            var orderedByUnits = allClassMethodsAndUnits
                .OrderByDescending(c => c.Value.Select(m => m.Value.Count).Sum())
                .ThenBy(c => c.Value.Count)
                .ThenBy(c => c.Key, StringComparer.Ordinal).ToArray();

            foreach (var @class in orderedByUnits)
            {
                var className = @class.Key;
                var methodsUnits = @class.Value;
                Console.WriteLine($"{className}:");

                foreach (var method in methodsUnits.OrderByDescending(m => m.Value.Count).ThenBy(m => m.Key, StringComparer.Ordinal))
                {
                    var methodName = method.Key;
                    var methodUnits = method.Value;
                    Console.WriteLine($"##{methodName}");

                    foreach (var unit in methodUnits.OrderBy(u => u.Length).ThenBy(u => u, StringComparer.Ordinal))
                    {
                        Console.WriteLine($"####{unit}");
                    }
                }
            }

            Console.WriteLine();
        }
    }
}
