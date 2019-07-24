using CSharp_Course_Project.Task1_StudentList;
using System;
using System.Collections.Generic;

namespace CSharp_Course_Project.Task2_StudentDictionary
{
    public class StudentDictionary
    {
        private readonly Dictionary<string, Student> students;

        public StudentDictionary()
        {
            this.students = new Dictionary<string, Student>();
        }

        public void ManageStudentDictionary()
        {
            while (true)
            {
                Console.WriteLine($"Please, choose one of the option:{Environment.NewLine}" +
                $"1 - Add student{Environment.NewLine}" +
                $"2 - Remove student{Environment.NewLine}" +
                $"3 - Print student list{Environment.NewLine}" +
                $"0 - Escape{Environment.NewLine}");
                var option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        this.AddStudent();
                        break;
                    case "2":
                        this.RemoveStudent();
                        break;
                    case "3":
                        this.PrintStudent();
                        break;
                    case "0":
                        break;
                    default:
                        Console.WriteLine("Wrong option. Please, try again...");
                        continue;
                }

                if (option == "0")
                    break;
            }
        }

        public void AddStudent()
        {
            while (true)
            {
                Console.Write("Please enter a student name: ");
                var name = Console.ReadLine();

                Console.Write("Please enter a student surname: ");
                var surname = Console.ReadLine();

                Console.Write("Please enter a student course (1-5): ");
                var course = Byte.TryParse(Console.ReadLine(), out byte courseNumber);

                Console.Write("Please enter a student group: ");
                var group = Console.ReadLine();

                Console.Write("Please enter a student faculty: ");
                var faculty = Console.ReadLine();

                var student = new Student(name, surname, courseNumber, group, faculty);
                this.students.Add($"{student.Name} {student.Surname}", student);

                Console.WriteLine("Do you want to add one more student? Y/N");
                var addResult = Console.ReadLine();

                if (addResult.ToLower() == "y")
                    continue;
                else
                    break;
            }
        }

        public void RemoveStudent()
        {
            Console.WriteLine($"Choose one of the option to remove student(s)?{Environment.NewLine}" +
                $"1 - Clear student list{Environment.NewLine}" +
                $"2 - Remove student by name and surname");
            var removeStatus = Console.ReadLine();

            if (removeStatus == "1")
            {
                this.students.Clear();
            }
            else if (removeStatus == "2")
            {
                Console.Write("Enter student name: ");
                var studentName = Console.ReadLine();
                Console.Write("Enter student surname: ");
                var studentSurname = Console.ReadLine();

                if (this.students.TryGetValue($"{studentName} {studentSurname}", out Student selectedStudent))
                {
                    this.students.Remove($"{studentName} {studentSurname}");
                }
                else
                {
                    Console.WriteLine("There is no such student. Try again...");
                }
            }
            else
            {
                Console.WriteLine("Wrong option. Please, try again...");
            }
        }

        public void PrintStudent()
        {
            foreach (var student in this.students)
                Console.WriteLine(student.ToString());

            Console.WriteLine($"Number of students: {this.students.Count}{Environment.NewLine}");
        }
    }
}
