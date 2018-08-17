using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.StudentGroups
{
    public class Group
    {
        public Group(Town town, List<Student> students)
        {
            Town = town;
            Students = students;
        }

        public Town Town { get; set; }

        public List<Student> Students { get; set; }
    }
}
