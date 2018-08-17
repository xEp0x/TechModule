using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Phonebook
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, string> myPhonebook = new Dictionary<string, string>();

            while (input != "END")
            {
                List<string> commands = input.Split().ToList();
                string command = commands[0];

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
                else if(command == "S")
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
                else
                {
                    Console.WriteLine("No such command!");
                }
  
                input = Console.ReadLine();
            }
        }
    }
}
