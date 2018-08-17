using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                var participants = Console.ReadLine().Split(',').Select(p => p.Trim()).ToList();
                var songs = Console.ReadLine().Split(',').Select(s => s.Trim()).ToList();
                var input = Console.ReadLine().Split(',').Select(i => i.Trim()).ToList();

                var dict = new Dictionary<string, List<string>>();
                while (input[0] != "dawn")
                {
                    var name = input[0];
                    var song = input[1];
                    var award = input[2];
                    if (songs.Contains(song))
                    {

                        if (!dict.ContainsKey(name))
                        {
                            dict[name] = new List<string>();
                        }
                        dict[name].Add(award);
                        dict[name] = dict[name].Distinct().ToList();
                    }
                    input = Console.ReadLine().Split(',').Select(i => i.Trim()).ToList();

                }
                if (dict.Values.Count() == 0)
                {
                    Console.WriteLine("No awards");
                }
                else
                {
                    foreach (var item in dict.OrderByDescending(x => x.Value.Count()).ThenBy(x => x.Key))
                    {

                        Console.WriteLine($"{item.Key}: {item.Value.Count()} awards");
                        foreach (var prize in item.Value.OrderBy(x => x))
                        {
                            Console.WriteLine($"--{prize}");
                        }
                    }
                }
            }
        }
    }
}
