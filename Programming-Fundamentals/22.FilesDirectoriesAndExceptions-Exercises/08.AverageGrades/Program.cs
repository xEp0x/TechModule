using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _08.AverageGrades
{
    class AverageGrades
    {
        static void Main(string[] args)
        {
            string[] fileLines = File.ReadAllLines(@"input.txt");
            var studentsAll = new List<Student>();

            for (int i = 0; i < fileLines.Length; i++)
            {
                var fileLine = fileLines[i].Split().ToList();
                Student currentStudent = new Student();

                currentStudent.Name = fileLine[0]; //fileLine.First();
                fileLine.RemoveAt(0); //inputLine.Skip(1);
                currentStudent.Grades = fileLine.Select(double.Parse).ToList();
                studentsAll.Add(currentStudent);
            }

            var studentsGoodGrade = studentsAll.Where(students => students.AverageGrade >= 5.0)
               .OrderBy(n => n.Name).ThenByDescending(n => n.AverageGrade).ToList(); //BETTER

            File.WriteAllText(@"output.txt", string.Empty);

            foreach (var student in studentsGoodGrade)
            {
                File.AppendAllText(@"output.txt", $"{student.Name} -> {student.AverageGrade:F2}\n");
            }
        }
    }
}
