using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _08.MentorGroup
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Mentor> mentors = new List<Mentor>();

            var inputLine = Console.ReadLine();
            inputLine = EnterMentorsAndAttendanceDates(inputLine, mentors);

            inputLine = Console.ReadLine();
            inputLine = EnterCommentsAboutMentors(inputLine, mentors);

            PrintMentorsCommentsAndAttendanceDates(mentors);
        }

        static void PrintMentorsCommentsAndAttendanceDates(List<Mentor> mentors)
        {
            var orderedMentors = mentors.OrderBy(m => m.Name).ToList();

            foreach (var mentor in orderedMentors)
            {
                Console.WriteLine($"{mentor.Name}");
                Console.WriteLine("Comments:");
                List<string> comments = mentor.Comment;

                foreach (var comment in comments)
                {
                    Console.WriteLine($"- {comment}");
                }

                Console.WriteLine("Dates attended:");
                List<DateTime> attendanceDates = mentor.AttendanceDate;
                attendanceDates = attendanceDates.OrderBy(d => d).ToList();

                foreach (var attendanceDate in attendanceDates)
                {
                    Console.WriteLine($"-- {attendanceDate:dd/MM/yyyy}");
                }
            }
        }

        static string EnterCommentsAboutMentors(string inputLine, List<Mentor> mentors)
        {
            while (inputLine != "end of comments")
            {
                var nameComment = inputLine.Split('-');
                var mentorName = nameComment[0];
                var comment = nameComment[1];

                var item = mentors.FirstOrDefault(m => m.Name == mentorName);

                if (item == null)
                {
                    inputLine = Console.ReadLine();
                    continue;
                }

                item.Comment.Add(comment);

                inputLine = Console.ReadLine();
            }

            return inputLine;
        }

        static string EnterMentorsAndAttendanceDates(string inputLine, List<Mentor> mentors)
        {
            while (inputLine != "end of dates")
            {
                List<DateTime> dates = new List<DateTime>();
                List<string> comments = new List<string>();
                var nameDate = inputLine.Split().ToList();
                var mentorName = nameDate[0];

                Mentor currentMentor = new Mentor(mentorName, dates, comments);
                var item = mentors.FirstOrDefault(m => m.Name == mentorName);

                if (nameDate.Count < 2)
                {                    
                    if (item == null)
                    {
                        mentors.Add(currentMentor);
                        inputLine = Console.ReadLine();
                        continue;
                    }
                }
                else
                {
                    var datesStrings = nameDate[1].Split(',').ToList();

                    foreach (var dateString in datesStrings)
                    {
                        var date = DateTime.ParseExact(dateString, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                        dates.Add(date);
                    }                    

                    if (item == null)
                    {
                        mentors.Add(currentMentor);
                        inputLine = Console.ReadLine();
                        continue;
                    }

                    item.AttendanceDate.AddRange(dates);
                }

                inputLine = Console.ReadLine();
            }

            return inputLine;
        }
    }
}
