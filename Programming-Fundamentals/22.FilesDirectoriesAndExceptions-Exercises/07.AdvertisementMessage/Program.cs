using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _07.AdvertisementMessage
{
    class AdvertisementMessage
    {
        static void Main(string[] args)
        {
            string[] phrases = File.ReadAllLines(@"phrases.txt");
            string[] events = File.ReadAllLines(@"events.txt");
            string[] authors = File.ReadAllLines(@"authors.txt");
            string[] cities = File.ReadAllLines(@"cities.txt");

            File.WriteAllText(@"output.txt", string.Empty);
            Random rnd = new Random();

            for (int i = 0; i < 10; i++)
            {
                var rndPhrase = rnd.Next(phrases.Length);
                var rndEvent = rnd.Next(events.Length);
                var rndAuthor = rnd.Next(authors.Length);
                var rndCity = rnd.Next(cities.Length);

                var message = phrases[rndPhrase] + " " + events[rndEvent] + " " + authors[rndAuthor] + " - " + cities[rndCity];
                File.AppendAllText(@"output.txt", message + "\n");
            }
        }
    }
}
