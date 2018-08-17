using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.AverageGrades
{
    class Program
    {
        static void Main(string[] args)
        {
            var studentsCount = int.Parse(Console.ReadLine());
            var studentsAll = new List<Student>();
            
            for (int i = 0; i < studentsCount; i++)
            {
                var inputLine = Console.ReadLine().Split().ToList();
                Student currentStudent = new Student();

                currentStudent.Name = inputLine[0]; //inputLine.First();
                inputLine.RemoveAt(0); //inputLine.Skip(1);

                currentStudent.Grades = inputLine.Select(double.Parse).ToList();
                studentsAll.Add(currentStudent);
            }

            var studentsGoodGrade = studentsAll.Where(students => students.AverageGrade >= 5.0).ToList();

            //var studentsGoodGrade = studentsAll.Where(students => students.AverageGrade >= 5.0)
            //    .OrderBy(n => n.Name).ThenByDescending(n => n.AverageGrade).ToList();  BETTER

            foreach (var student in studentsGoodGrade.OrderBy(n => n.Name).ThenByDescending(n => n.AverageGrade))
            {
                Console.WriteLine($"{student.Name} -> {student.AverageGrade:F2}");
            }
        }
    }
}
