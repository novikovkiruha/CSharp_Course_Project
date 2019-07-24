using System;
using System.Collections.Generic;

namespace CSharp_Course_Project.Task1_StudentList
{
    public class StudentManager
    {
        private readonly List<Student> students;

        public StudentManager()
        {
            this.students = new List<Student>();
        }

        public void ManageStudentList()
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

                this.students.Add(new Student(name, surname, courseNumber, group, faculty));

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

                for (int i = 0; i < this.students.Count; i++)
                {
                    if (students[i].Name == studentName && students[i].Surname == studentSurname)
                        this.students.RemoveAt(i);
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
