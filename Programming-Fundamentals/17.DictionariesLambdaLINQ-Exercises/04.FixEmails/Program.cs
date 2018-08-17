using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.FixEmails
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, string> namesEmails = new Dictionary<string, string>();

            while (input != "stop")
            {
                string name = input;
                string mail = Console.ReadLine();

                namesEmails[name] = mail;

                input = Console.ReadLine();
            }

            var fixedNameEmails = namesEmails.Where(kvp => !(kvp.Value.EndsWith("us")
                || kvp.Value.EndsWith("uk"))).ToDictionary(kvp => kvp.Key, kvp => kvp.Value);

            //    List<string> valuesToDelete = pad.Values.Where(v => ((String.Join("", v.Skip(v.Length - 2)) == "us")
            //    || (String.Join("", v.Skip(v.Length - 2)) == "uk"))).ToList();

            //     List<string> keysToDelete = new List<string>();
            //
            //     foreach (var pair in namesEmails)
            //     {
            //         List<char> mail = pair.Value.ToList();
            //         string domain = String.Join("", mail.Skip(mail.Count - 2)).ToLower();
            //
            //         if (domain == "us" || domain == "uk")
            //         {
            //             keysToDelete.Add(pair.Key);
            //         }
            //     }
            //
            //     foreach (var key in keysToDelete)
            //     {
            //         namesEmails.Remove(key);
            //     }

            foreach (var nameEmail in fixedNameEmails)
            {
                var name = nameEmail.Key;
                var email = nameEmail.Value;

                Console.WriteLine($"{name} -> {email}");
            }
        }
    }
}
