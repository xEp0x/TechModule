using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.TeamworkProjects
{
    class Program
    {
        static void Main(string[] args)
        {
            var teamCount = int.Parse(Console.ReadLine());
            List<Team> teams = new List<Team>();

            EnterTeamsAndCreators(teamCount, teams);

            var inputLine = Console.ReadLine();

            while (inputLine != "end of assignment")
            {
                var memberTeam = inputLine.Split(new char[] { '-', '>' }, StringSplitOptions.RemoveEmptyEntries);
                var currentMember = memberTeam[0];
                var currentTeam = memberTeam[1];

                var itemTeam = teams.FirstOrDefault(t => t.Name == currentTeam);

                if (itemTeam == null)
                {
                    Console.WriteLine($"Team {currentTeam} does not exist!");
                    inputLine = Console.ReadLine();
                    continue;
                }

                //prowerka dali w spisyka s otbori syzdatelq ne e tekushtiq user
                var itemCreator = teams.Any(t => t.Creator == currentMember);

                //prowerka w celia spisak s otbori ima li go tekushtia user w nqkoj drug otbor
                var itemMember = teams.Any(t => t.Members.Contains(currentMember));

                if (itemCreator || itemMember )
                {
                    Console.WriteLine($"Member {currentMember} cannot join team {currentTeam}!");
                    inputLine = Console.ReadLine();
                    continue;
                }

                itemTeam.Members.Add(currentMember);
                inputLine = Console.ReadLine();
            }

            teams = teams.OrderByDescending(t => t.Members.Count).ThenBy(t => t.Name).ToList();

            foreach (var team in teams)
            {
                var members = team.Members;

                if (members.Count == 0)
                {
                    continue;
                }

                Console.WriteLine($"{team.Name}");
                Console.WriteLine($"- {team.Creator}");

                members = members.OrderBy(n => n).ToList();

                foreach (var member in members)
                {
                    Console.WriteLine($"-- {member}");
                }
            }

            var teamsForDisband = teams.Where(t => t.Members.Count == 0).OrderBy(t => t.Name).ToList();

            Console.WriteLine("Teams to disband:");
            foreach (var teamDisband in teamsForDisband)
            {
                Console.WriteLine($"{teamDisband.Name}");
            }
        }

        static void EnterTeamsAndCreators(int teamCount, List<Team> teams)
        {
            for (int i = 0; i < teamCount; i++)
            {
                var inputLine = Console.ReadLine().Split('-');
                var currentTeamCreator = inputLine[0];
                var currentTeamName = inputLine[1];

                List<string> members = new List<string>();
                Team currentTeam = new Team(currentTeamName, currentTeamCreator, members);

                var itemTeamName = teams.FirstOrDefault(t => t.Name == currentTeamName);

                if (itemTeamName != null)
                {
                    Console.WriteLine($"Team {currentTeamName} was already created!");
                    continue;
                }

                var itemCreator = teams.FirstOrDefault(t => t.Creator == currentTeamCreator);

                if (itemCreator != null)
                {
                    Console.WriteLine($"{currentTeamCreator} cannot create another team!");
                    continue;
                }

                teams.Add(currentTeam);
                Console.WriteLine($"Team {currentTeamName} has been created by {currentTeamCreator}!");
            }
        }
    }
}
