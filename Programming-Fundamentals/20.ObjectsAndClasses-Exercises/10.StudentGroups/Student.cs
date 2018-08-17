using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.StudentGroups
{
    public class Student
    {
        public Student(string name, string email, DateTime registrationDate)
        {
            Name = name;
            Email = email;
            RegistrationDate = registrationDate;
        }

        public string Name { get; set; }

        public string Email { get; set; }

        public DateTime RegistrationDate { get; set; }
    }
}
