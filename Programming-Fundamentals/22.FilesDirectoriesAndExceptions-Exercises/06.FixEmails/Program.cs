using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace _06.FixEmails
{
    class FixEmails
    {
        static void Main(string[] args)
        {
            string[] fileLines = File.ReadAllLines(@"input.txt");
            File.WriteAllText(@"output.txt", string.Empty);
            
            for (int i = 0; i < fileLines.Length; i += 2)
            {
                var name = fileLines[i];
                var mail = fileLines[i+1].ToCharArray();
                var domain = String.Join("", mail.Skip(mail.Length - 2)).ToLower();

                StringBuilder sb = new StringBuilder();
                if (domain == "us" || domain == "uk")
                {
                    continue;
                }
                else
                {
                    sb.Append(name);
                    sb.Append(" -> ");
                    sb.Append(string.Join("", mail));
                    File.AppendAllText(@"output.txt", sb.ToString() + "\n");
                }                
            }
        }
    }
}
