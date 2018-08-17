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
            var inputLine = Console.ReadLine();
            var inputLineSplitedToCommand = inputLine.Split().ToList();
            var command = inputLineSplitedToCommand[0];
            var venuesSingerPrice = new Dictionary<string, Dictionary<string, int>>();

            while (command != "End")
            {
                var isInputCorrect = CheckIsInputCorrect(inputLine);
                
                if (!isInputCorrect)
                {
                    inputLine = Console.ReadLine();
                    inputLineSplitedToCommand = inputLine.Split().ToList();
                    command = inputLineSplitedToCommand[0];
                    continue;
                }

                var inputLineSplitedToSingerVenue = inputLine.Split('@').ToList();
                var singer = inputLineSplitedToSingerVenue[0].Remove(inputLineSplitedToSingerVenue[0].Length - 1);
                var venueTickets = inputLineSplitedToSingerVenue[1]
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                var ticketCount = int.Parse(venueTickets[venueTickets.Count - 1]);
                var ticketPrice = int.Parse(venueTickets[venueTickets.Count - 2]);
                venueTickets.RemoveRange(venueTickets.Count - 2, 2);
                var venueName = string.Join(" ", venueTickets);
                var totalPriceSinger = ticketCount * ticketPrice;

                if (!venuesSingerPrice.ContainsKey(venueName))
                {
                    var currentSingerPrice = new Dictionary<string, int>();
                    currentSingerPrice.Add(singer, totalPriceSinger);
                    venuesSingerPrice.Add(venueName, currentSingerPrice);
                }
                else
                {
                    var knownSingerPrice = new Dictionary<string, int>();
                    knownSingerPrice = venuesSingerPrice[venueName];

                    if (!knownSingerPrice.ContainsKey(singer))
                    {
                        knownSingerPrice.Add(singer, totalPriceSinger);
                        venuesSingerPrice[venueName] = knownSingerPrice;
                    }
                    else
                    {
                        knownSingerPrice[singer] += totalPriceSinger;
                        venuesSingerPrice[venueName] = knownSingerPrice;
                    }
                }

                inputLine = Console.ReadLine();
                inputLineSplitedToCommand = inputLine.Split().ToList();
                command = inputLineSplitedToCommand[0];
            }

            PrintVenueSingerTotalPrice(venuesSingerPrice);
        }

        static void PrintVenueSingerTotalPrice(Dictionary<string, Dictionary<string, int>> venuesSingerPrice)
        {
            var knownSingerPrice = new Dictionary<string, int>();

            foreach (var venueSingerPrice in venuesSingerPrice)
            {
                Console.WriteLine(venueSingerPrice.Key);
                knownSingerPrice = venueSingerPrice.Value;

                foreach (var singerPrice in knownSingerPrice.OrderByDescending(price => price.Value))
                {
                    Console.WriteLine($"#  {singerPrice.Key} -> {singerPrice.Value}");
                }
            }
        }

        static bool CheckIsInputCorrect(string inputLine)
        {
            var isInputCorrect = true;

            var inputList = inputLine.ToCharArray().ToList();
            var indexAtSign = inputList.IndexOf('@');
            var isAtSignOnPlace = inputList[indexAtSign - 1] == ' ' && char.IsLetter(inputList[indexAtSign + 1]);

            if (isAtSignOnPlace)
            {
                var splitedInputList = inputLine.Split('@').ToList();
                var singer = splitedInputList[0].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                var venueTickets = splitedInputList[1].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();

                if (0 < singer.Count && singer.Count < 4)
                {
                    if (2 < venueTickets.Count && venueTickets.Count < 6)
                    {
                        var count = venueTickets.Count;

                        var isTicketPriceNumber = int.TryParse(venueTickets[count - 2], out int ticketPrice);
                        //var isTicketPriceNumber = venueTickets[count - 2].All(char.IsDigit);
                        var isTicketCountNumber = int.TryParse(venueTickets[count - 1], out int ticketCount);
                        //var isTicketPriceNumber = venueTickets[count - 1].All(char.IsDigit);

                        if (isTicketPriceNumber && isTicketCountNumber)
                        {
                            for (int i = 0; i < venueTickets.Count - 2; i++)
                            {
                                var isVenueNameOnlyLetters = venueTickets[i].All(char.IsLetter);
                                if (isVenueNameOnlyLetters)
                                {
                                    continue;
                                    //Console.WriteLine("Venue name is OK!"); 
                                }
                                //Console.WriteLine("Venue name is incorrect!");
                                return false;
                            }
                        }
                        else
                        {
                            //Console.WriteLine("Tickets are incorrect!");
                            return false;
                        }

                    }
                    else
                    {
                        //Console.WriteLine("Venue or tickets counts are incorrect!");
                        return false;
                    }
                }
                else
                {
                    //Console.WriteLine("@ is not on place!");
                    return false;
                }
            }
            else
            {
                //Console.WriteLine("@ is not on place!");
                return false;
            }

            return isInputCorrect;
        }
    }
}