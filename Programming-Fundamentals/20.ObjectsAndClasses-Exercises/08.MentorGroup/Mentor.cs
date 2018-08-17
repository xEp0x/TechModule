using System;
using System.Collections.Generic;

namespace _08.MentorGroup
{
    public class Mentor
    {
        public Mentor(string name, List<DateTime> attendanceDate, List<string> comment)
        {
            Name = name;
            AttendanceDate = attendanceDate;
            Comment = comment;
        }

        public string Name { get; set; }

        public List<DateTime> AttendanceDate { get; set; }

        public List<string> Comment { get; set; }
    }
}
