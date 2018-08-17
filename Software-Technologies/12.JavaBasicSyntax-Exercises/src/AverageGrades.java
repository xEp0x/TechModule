import java.util.ArrayList;
import java.util.Comparator;
import java.util.List;
import java.util.Scanner;
import java.util.stream.Collectors;

public class AverageGrades {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        String[] input = scanner.nextLine().split(" ");
        int n = Integer.parseInt(input[0]);
        ArrayList<Student> students = new ArrayList<Student>();

        for (int i = 0; i < n; i++) {
            String[] inputParts = scanner.nextLine().split(" ");
            Student currentStudent = new Student();
            currentStudent.name = inputParts[0];
            ArrayList<Double> currentStudentGrades = new ArrayList<Double>();

            for (int j = 1; j < inputParts.length; j++) {
                currentStudentGrades.add(Double.parseDouble(inputParts[j]));
            }

            double sum = 0;
            for (int j = 0; j < currentStudentGrades.size(); j++) {
                sum += currentStudentGrades.get(j);
            }
            double avgGrade = sum / currentStudentGrades.size();
            currentStudent.setGrades(currentStudentGrades);
            currentStudent.setAverageGrade(avgGrade);
            students.add(currentStudent);
        }

        List<Student> studentsResult = students
                .stream()
                .filter(s -> s.averageGrade >= 5.00)
                .sorted(Comparator.comparing(Student::getName).thenComparing(Student::getAverageGrade, Comparator.reverseOrder()))
                .collect(Collectors.toList());

        for (int i = 0; i < studentsResult.size(); i++) {
            System.out.printf("%s -> %.2f%s", studentsResult.get(i).name, studentsResult.get(i).averageGrade, "\n");
        }
    }

    public static class Student {
        private String name;
        public String getName() {
            return name;
        }
        public void setName(String name) {
            this.name = name;
        }

        public ArrayList<Double> grades;
        public ArrayList<Double> getGrades() {
            return grades;
        }
        public void setGrades(ArrayList<Double> grades) {
            this.grades = grades;
        }

        public double averageGrade;
        public double getAverageGrade() {
            return averageGrade;
        }
        public void setAverageGrade(double averageGrade) {
            this.averageGrade = averageGrade;
        }
    }
}
