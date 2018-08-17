using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.AdvertisementMessage
{
    class Program
    {
        static void Main(string[] args)
        {
            var fakeMessageCount = int.Parse(Console.ReadLine());

            var phrases = new List<string>
            {
                "Excellent product.",
                "Such a great product.",
                "I always use that product.",
                "Best product of its category.",
                "Exceptional product.",
                "I can’t live without this product."
            };

            var events = new List<string>
            {
                "Now I feel good.",
                "I have succeeded with this product.",
                "Makes miracles. I am happy of the results!",
                "I cannot believe but now I feel awesome.",
                "Try it yourself, I am very satisfied.",
                "I feel great!"
            };

            var authors = new List<string>
            {
                "Diana",
                "Petya",
                "Stella",
                "Elena",
                "Katya",
                "Iva",
                "Annie",
                "Eva"
            };

            var cities = new List<string>
            {
                "Burgas",
                "Sofia",
                "Plovdiv",
                "Varna",
                "Ruse"
            };

            for (int i = 0; i < fakeMessageCount; i++)
            {
                var randomPhrase = GetRandomStrings(phrases);
                var randomEvent = GetRandomStrings(events);
                var randomAuthor = GetRandomStrings(authors);
                var randomCity= GetRandomStrings(cities);
                Console.WriteLine($"{randomPhrase} {randomEvent} {randomAuthor} – {randomCity}.");
            }

        }

        static string GetRandomStrings(List<string> parts)
        {
            Random rnd = new Random();
          
            var index = rnd.Next(parts.Count);
            var randomString = parts[index];       

            return randomString;
        }
    }
}
