using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.SoftUniKaraoke
{
    class SoftUniKaraoke
    {
        static void Main(string[] args)
        {
            //char[] delimiters = new char[] { ',', ' ', '\t' };


            //Regex.Split(Console.ReadLine(), @"\s*,\s*"); Spliwame po zapetaq i proizwolen broj whitespace predi i sled zapetaiata
            //Ekwiwalentno e na dolnotos split po zapetaia i trimwane na whitespace 

            var participants = Console.ReadLine().Split(',').Select(p => p.Trim()).ToList();
            var songs = Console.ReadLine().Split(',').Select(s => s.Trim()).ToList();
            Dictionary<string, List<string>> participantsAward = new Dictionary<string, List<string>>();
            //Dictionary<string, string> participantsPerformance = new Dictionary<string, string>();
            var inputLine = Console.ReadLine();

            while (inputLine != "dawn")
            {
                var performance = inputLine.Split(',').Select(p => p.Trim()).ToList();
                var participant = performance[0];
                var song = performance[1];
                var award = performance[2];

                if (!participants.Contains(participant) || !songs.Contains(song))
                {
                    inputLine = Console.ReadLine();
                    continue;
                }

                if (!participantsAward.ContainsKey(participant))
                {
                    participantsAward[participant] = new List<string>();
                }

                if (!participantsAward[participant].Contains(award))
                {
                    participantsAward[participant].Add(award);
                }

                inputLine = Console.ReadLine();
            }


            if (participantsAward.Count == 0)
            {
                Console.WriteLine("No awards");
            }

            var sortedParticipantsByAwardsCount = participantsAward.OrderByDescending(p => p.Value.Count).ThenBy(p => p.Key);

            foreach (var participantAwards in sortedParticipantsByAwardsCount)
            {
                var participant = participantAwards.Key;
                var awards = participantAwards.Value;

                Console.WriteLine($"{participant}: {awards.Count} awards");
                foreach (var award in awards.OrderBy(a => a))
                {
                    Console.WriteLine($"--{award}");
                }
            }
        }
    }
}
