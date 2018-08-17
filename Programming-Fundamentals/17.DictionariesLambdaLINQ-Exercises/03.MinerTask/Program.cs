using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.MinerTask
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, int> resources = new Dictionary<string, int>();

            while (input != "stop")
            {
                string resource = input;
                int quantity = int.Parse(Console.ReadLine());

                //    if (resources.ContainsKey(resource))
                //    {
                //        resources[resource] += quantity;          // One way to fill the dictionary
                //    }
                //    else
                //    {
                //        resources.Add(resource, quantity);
                //    }

                if (!resources.ContainsKey(resource))
                {
                    resources[resource] = 0;
                }

                resources[resource] += quantity;

                input = Console.ReadLine();
            }

            foreach (var pair in resources)
            {
                var resource = pair.Key;
                var quantity = pair.Value;
                Console.WriteLine($"{resource} -> {quantity}");
            }
        }
    }
}
