using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.FootballStandings
{
    class Program
    {
        static void Main(string[] args)
        {
            var key = Regex.Escape(Console.ReadLine());
            var pattern = string.Format
                (@"^.*(?:{0})(?<team1>[A-Za-z]*)(?:{0}).*(?:{0})(?<team2>[A-Za-z]*)(?:{0}).*?(?<team1Goals>\d+):(?<team2Goals>\d+).*$", key);

            Regex regex = new Regex(pattern);
            Dictionary<string, TeamStats> allTeamStats = new Dictionary<string, TeamStats>();

            while (true)
            {
                var inputLine = Console.ReadLine();

                if (inputLine == "final")
                {
                    break;
                }

                Match footballMatch = regex.Match(inputLine);
                var firstTeam = new string(footballMatch.Groups["team1"].Value.ToUpper().Reverse().ToArray());
                var secondTeam = new string(footballMatch.Groups["team2"].Value.ToUpper().Reverse().ToArray());
                var firstTeamGoals = int.Parse(footballMatch.Groups["team1Goals"].Value.ToString());
                var secondTeamGoals = int.Parse(footballMatch.Groups["team2Goals"].Value.ToString());

                if (!allTeamStats.ContainsKey(firstTeam))
                {
                    allTeamStats[firstTeam] = new TeamStats();
                }

                allTeamStats[firstTeam].Goals += firstTeamGoals;

                if (!allTeamStats.ContainsKey(secondTeam))
                {
                    allTeamStats[secondTeam] = new TeamStats();
                }

                allTeamStats[secondTeam].Goals += secondTeamGoals;

                if (firstTeamGoals > secondTeamGoals)  //first team is a winner
                {
                    allTeamStats[firstTeam].Points += 3;
                }
                else if (secondTeamGoals > firstTeamGoals)  //second team is a winner
                {
                    allTeamStats[secondTeam].Points += 3;
                }
                else  // the match is draw
                {
                    allTeamStats[firstTeam].Points += 1;
                    allTeamStats[secondTeam].Points += 1;
                }

                // Console.WriteLine();
            }

            var allTeamsOrderedByPoints = allTeamStats.OrderByDescending(t => t.Value.Points).ThenBy(t => t.Key).ToArray();
            var pos = 0;

            Console.WriteLine("League standings:");
            foreach (var teamPoints in allTeamsOrderedByPoints)
            {
                pos += 1;
                var team = teamPoints.Key;
                var points = teamPoints.Value.Points;

                Console.WriteLine($"{pos}. {team} {points}");
            }

            var top3TeamsGoals = allTeamStats.OrderByDescending(t => t.Value.Goals).ThenBy(t => t.Key).Take(3).ToArray();

            Console.WriteLine("Top 3 scored goals:");
            foreach (var teamGoals in top3TeamsGoals)
            {
                var team = teamGoals.Key;
                var goals = teamGoals.Value.Goals;
                Console.WriteLine($"- {team} -> {goals}");
            }
        }
    }

    public class TeamStats
    {
        public int Goals { get; set; }

        public int Points { get; set; }
    }
}
