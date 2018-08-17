using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _10.StudentGroups
{
    class StudentGroups
    {
        static void Main(string[] args)
        {
            //char[] charsToTrim = new char[] { ' ' };
            var inputLine = Console.ReadLine();
            List<Town> towns = new List<Town>();
            Dictionary<string, List<Group>> townGroups = new Dictionary<string, List<Group>>();

            inputLine = EnterTownsSeatsAndStudents(inputLine, towns);

            towns = OrderTownsAndStudents(towns);

            townGroups = CreateGroupsByTownAndSeats(towns, townGroups);

            var townCounts = townGroups.Count();
            var groupCounts = townGroups.Select(t => t.Value.Count).Sum();
            Console.WriteLine($"Created {groupCounts} groups in {townCounts} towns:");

            PrintInfoByTownAndByGroups(townGroups);

            Console.WriteLine();
        }

        static void PrintInfoByTownAndByGroups(Dictionary<string, List<Group>> townGroups)
        {
            foreach (var town in townGroups)
            {
                var groups = town.Value;
                foreach (var group in groups)
                {
                    Console.Write($"{group.Town.Name} => ");
                    var studentsEmail = group.Students.Select(s => s.Email).ToList();
                    Console.WriteLine(string.Join(", ", studentsEmail));
                }
            }
        }

        static Dictionary<string, List<Group>> CreateGroupsByTownAndSeats(List<Town> towns, Dictionary<string, List<Group>> townGroups)
        {
            foreach (var town in towns)
            {
                var townName = town.Name;
                var hallSeats = town.SeatCount;
                var townStudents = town.Students;
                List<Group> groupsByTown = new List<Group>();

                while (townStudents.Any())
                {
                    var groupTownStudents = townStudents.Take(hallSeats).ToList();
                    var group = new Group(town, groupTownStudents);
                    groupsByTown.Add(group);
                    townStudents = townStudents.Skip(hallSeats).ToList();
                }

                townGroups.Add(townName, groupsByTown);
            }

            return townGroups;
        }

        private static List<Town> OrderTownsAndStudents(List<Town> towns)
        {
            foreach (var town in towns)
            {
                var students = town.Students;
                var orderedStudents = students.OrderBy(s => s.RegistrationDate).ThenBy(s => s.Name).ThenBy(s => s.Email).ToList();
                town.Students = orderedStudents;
            }

            towns = towns.OrderBy(t => t.Name).ToList();
            return towns;
        }

        static string EnterTownsSeatsAndStudents(string inputLine, List<Town> towns)
        {
            while (inputLine != "End")
            {
                if (inputLine.Contains("=>"))   //Town and hall seats
                {
                    var splitedInputLine = inputLine.Split(new char[] { '=', '>' }, StringSplitOptions.RemoveEmptyEntries);
                    var townName = splitedInputLine[0].Trim();
                    var seatsString = splitedInputLine[1];
                    var splitedSeatsString = seatsString.Trim().Split();
                    var seats = int.Parse(splitedSeatsString[0]);

                    List<Student> students = new List<Student>();
                    Town currentTown = new Town(townName, seats, students);

                    towns.Add(currentTown);
                }
                else //Student- name, email, registration date. Delimiter |
                {
                    var splitedInputLine = inputLine.Split('|');
                    var studentName = splitedInputLine[0].Trim();
                    var email = splitedInputLine[1].Trim();
                    var registrationDate = DateTime.ParseExact(splitedInputLine[2].Trim(), "d-MMM-yyyy"
                        , CultureInfo.InvariantCulture);

                    Student currentStudent = new Student(studentName, email, registrationDate);
                    var lastTown = towns.Last();
                    lastTown.Students.Add(currentStudent);
                }

                inputLine = Console.ReadLine();
            }

            return inputLine;
        }
    }
}
