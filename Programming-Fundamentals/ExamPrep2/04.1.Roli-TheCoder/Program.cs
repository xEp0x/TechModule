using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _04._1.Roli_TheCoder
{
    class Program
    {
        static void Main(string[] args)
        {
            //var pattern = @"(?<id>\d+)\s+#(?<eventName>\w+)(\s+(?:@[A-Za-z0-9'-]+\s*)+)?";
            var pattern = @"(?<id>\d+)\s+#(?<eventName>\w+)(\s+(?<participants>@[A-Za-z0-9'-]+\s*)+)?";
            //var pattern = @"(?<id>\d+)\s+#(?<eventName>\w+)(\s+(?<participants>(@[A-Za-z0-9'-]+\s*)+)?)";
            Regex regex = new Regex(pattern);
            Dictionary<int, Event> events = new Dictionary<int, Event>();

            while (true)
            {
                var inputLine = Console.ReadLine();

                if (inputLine == "Time for Code")
                {
                    break;
                }

                Match inputMatch = regex.Match(inputLine);

                if (!inputMatch.Success)
                {
                    continue;
                }

                var id = int.Parse(inputMatch.Groups["id"].Value);
                var eventName = inputMatch.Groups["eventName"].Value;
                var participants = inputMatch.Groups[1].Value
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();

                if (!events.ContainsKey(id))
                {
                    Event currentEvent = new Event
                    {
                        Name = eventName,
                        Participants = new List<string>()
                    };
                    events[id] = currentEvent;
                }

                var existIdEvent = events[id];

                if (existIdEvent.Name == eventName)
                {
                    existIdEvent.Participants.AddRange(participants);
                    existIdEvent.Participants = existIdEvent.Participants.Distinct().ToList();
                    events[id] = existIdEvent;
                }
            }

            var sortedEvents = events
                .OrderByDescending(e => e.Value.Participants.Count())
                .ThenBy(e => e.Value.Name)
                .ToDictionary(kvp => kvp.Key, kvp => kvp.Value);

            foreach (var eventRoli in sortedEvents)
            {
                var currentEventName = eventRoli.Value.Name;
                var currentEventPrticipants = eventRoli.Value.Participants;

                Console.WriteLine($"{currentEventName} - {currentEventPrticipants.Count}");
                foreach (var participant in currentEventPrticipants.OrderBy(p => p))
                {
                    Console.WriteLine($"{participant}");
                }
            }
        }
    }

    public class Event
    {
        public string Name { get; set; }

        public List<string> Participants { get; set; }
    }
}
