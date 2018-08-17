using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.HandsOfCards
{
    class Program
    {
        static void Main(string[] args)
        {

            var commandDelimiter = ':';

            var namesCards = new Dictionary<string, List<int>>();

            List<string> input = Console.ReadLine().Split(commandDelimiter).ToList();
            var command = input[0];

            while (command != "JOKER")
            {
                char[] cardDelimiters = { ',', ' ' };
                var name = input[0];
                var cards = input[1].Split(", ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                    .Select(CalcCardValue).ToArray();

                if (!namesCards.ContainsKey(name))
                {
                    namesCards[name] = new List<int>();
                }

                namesCards[name].AddRange(cards);

                Console.WriteLine();

                input = Console.ReadLine().Split(commandDelimiter).ToList();
                command = input[0];
            }

            foreach (var nameCard in namesCards)
            {
                var name = nameCard.Key;
                var cards = nameCard.Value;

                var sumPoints = cards.Distinct().Sum();

                Console.WriteLine($"{name}: {sumPoints}");
            }


        }

        static int CalcCardValue(string card)
        {
            var cardPower = new Dictionary<string, int>();
            var cardType = new Dictionary<string, int>();

            for (int i = 2; i <= 10; i++)
            {
                cardPower[i.ToString()] = i;
            }

            cardPower["J"] = 11;
            cardPower["Q"] = 12;
            cardPower["K"] = 13;
            cardPower["A"] = 14;

            cardType["C"] = 1;
            cardType["D"] = 2;
            cardType["H"] = 3;
            cardType["S"] = 4;

            var currentCardPower = card.Substring(0, card.Length - 1);
            var currentCardType = card.Substring(card.Length - 1);
            var currentCardPoints = cardPower[currentCardPower] * cardType[currentCardType];

            return currentCardPoints;
        }
    }
}
