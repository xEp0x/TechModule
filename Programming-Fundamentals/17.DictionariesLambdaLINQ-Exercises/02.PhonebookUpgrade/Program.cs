using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.PhonebookUpgrade
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> commands = Console.ReadLine().Split().ToList();
            SortedDictionary<string, string> myPhonebook = new SortedDictionary<string, string>();

            string command = commands[0];

            while (command != "END")
            {
                if (command == "A")
                {
                    string name = commands[1];
                    string phoneNumber = commands[2];

                    if (myPhonebook.ContainsKey(name))
                    {
                        myPhonebook[name] = phoneNumber;
                    }
                    else
                    {
                        myPhonebook.Add(name, phoneNumber);
                    }
                }
                else if (command == "S")
                {
                    string name = commands[1];

                    if (myPhonebook.ContainsKey(name))
                    {
                        Console.WriteLine($"{name} -> {myPhonebook[name]}");
                    }
                    else
                    {
                        Console.WriteLine($"Contact {name} does not exist.");
                    }
                }
                else if (command == "ListAll")
                {
                    foreach (var pair in myPhonebook)
                    {
                        Console.WriteLine($"{pair.Key} -> {pair.Value}");
                    }
                }
                else
                {
                    Console.WriteLine("No such command!");
                }

                commands = Console.ReadLine().Split().ToList();
                command = commands[0];
            }
        }
    }
}
