using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.StudentGroups
{
    public class Town
    {
        public Town(string name, int seatCount, List<Student> students)
        {
            Name = name;
            SeatCount = seatCount;            
            Students = students;
        }

        public string Name { get; set; }

        public int SeatCount { get; set; }

        public List<Student> Students {get; set;}
    }
}
