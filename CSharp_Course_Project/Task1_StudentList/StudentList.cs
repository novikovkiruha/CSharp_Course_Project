using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Course_Project.Task1_StudentList
{
    public class StudentList
    {
        internal readonly List<Student> students = new List<Student>();
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

                //var name = "name1";
                //var surname = "surname1";
                //byte courseNumber = 2;
                //var group = "C";
                //var faculty = "Ec";

                this.students.Add(new Student(name, surname, courseNumber, group, faculty));

                Console.WriteLine("Do you want to add one more student? Y/N");
                var addResult = Console.ReadLine();
                if (addResult.ToLower() == "y")
                    continue;
                else
                {
                    foreach (var student in this.students)
                        Console.WriteLine(student.ToString());
                    Console.WriteLine($"Number of students: {this.students.Count}{Environment.NewLine}");
                    break;
                }
            }

            RemoveStudent();

            foreach (var student in this.students)
                Console.WriteLine(student.ToString());
            Console.WriteLine($"Number of students: {this.students.Count}{Environment.NewLine}");
        }

        public void RemoveStudent()
        {
            Console.WriteLine("Do you want to remove student? Y/N");
            var removeResult = Console.ReadLine();
            if (removeResult.ToLower() == "y")
            {
                Console.WriteLine($"Choose one of the option to remove student(s)?{Environment.NewLine}" +
                    $"1 - All{Environment.NewLine}" +
                    $"2 - By One");
                var removeStatus = Console.ReadLine();
                if (removeStatus == "1")
                    this.students.Clear();
                else if (removeStatus == "2")
                {
                    Console.Write("Enter the name of student: ");
                    var studentName = Console.ReadLine();
                    Console.Write("Enter the surname of student: ");
                    var studentSurname = Console.ReadLine();

                    for (int i = 0; i < this.students.Count; i++)
                    {
                        if (students[i].Name == studentName && students[i].Surname == studentSurname)
                        {
                            this.students.RemoveAt(i);
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Wrong option");
                }
            }
        }
    }
}
