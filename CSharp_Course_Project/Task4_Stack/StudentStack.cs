using CSharp_Course_Project.Task1_StudentList;
using System;
using System.Collections.Generic;

namespace CSharp_Course_Project.Task4_Stack
{
    public class StudentStack
    {
        private readonly Dictionary<string, Student> students = new Dictionary<string, Student>();

        private readonly Queue<string> tasks = new Queue<string>();

        public StudentStack()
        {
            this.students = new Dictionary<string, Student>();
            this.tasks = new Queue<string>();
        }

        public void ManageStudentStack()
        {
            while (true)
            {
                Console.WriteLine($"Please, choose one of the option:{Environment.NewLine}" +
                $"1 - Add student{Environment.NewLine}" +
                $"2 - Remove student{Environment.NewLine}" +
                $"3 - Print student list{Environment.NewLine}" +
                $"4 - Manage task{Environment.NewLine}" +
                $"5 - Manage library books{Environment.NewLine}" +
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
                    case "4":
                        this.ManageTask();
                        break;
                    case "5":
                        this.ManageBookLibrary();
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

                this.students.Remove($"{studentName} {studentSurname}");
            }
            else
                Console.WriteLine("Wrong option. Please, try again...");
        }

        public void ManageTask()
        {
            while (true)
            {
                Console.WriteLine($"Choose action:{Environment.NewLine}" +
                                $"1 - Add task{Environment.NewLine}" +
                                $"2 - Remove task{Environment.NewLine}" +
                                $"3 - Print tasks{Environment.NewLine}" +
                                $"4 - Assign tasks{Environment.NewLine}" +
                                $"0 - Escape{Environment.NewLine}");
                var action = Console.ReadLine();

                switch (action)
                {
                    case "1":
                        Console.Write("Add a task name: ");
                        var taskName = Console.ReadLine();
                        this.tasks.Enqueue(taskName);
                        break;
                    case "2":
                        Console.WriteLine($"{this.tasks.Peek()} was removed");
                        this.tasks.Dequeue();
                        break;
                    case "3":
                        foreach (var task in this.tasks)
                            Console.WriteLine(task);
                        break;
                    case "4":
                        if (this.students.Count > 0 && this.tasks.Count > 0)
                        {
                            foreach (var value in this.students.Values)
                                value.CompleteTaskList(this.tasks);
                        }
                        else if (this.students.Count <= 0)
                        {
                            Console.WriteLine("There is no students to assign the tasks. Please, add new student at first...");
                            continue;
                        }
                        else if (this.tasks.Count <= 0)
                        {
                            Console.WriteLine("There is no tasks to assign. Please, add new task at first...");
                            continue;
                        }
                        break;
                    case "0":
                        break;
                    default:
                        Console.WriteLine("Wrong option. Please, try again...");
                        continue;
                }

                if (action == "0")
                    break;
            }
        }

        public void ManageBookLibrary()
        {
            while (true)
            {
                if (this.students.Count > 0)
                {
                    Console.WriteLine($"Please, select the option:{Environment.NewLine}" +
                        $"1 - Take the book from the library{Environment.NewLine}" +
                        $"2 - Return the book to the library{Environment.NewLine}" +
                        $"0 - Escape{Environment.NewLine}");
                    string option = Console.ReadLine();

                    switch (option)
                    {
                        case "1":
                            foreach (var value in this.students.Values)
                                value.TakeLibraryBook();
                            break;
                        case "2":
                            foreach (var value in this.students.Values)
                                value.ReturnLibraryBook();
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
                else if (this.students.Count <= 0)
                {
                    Console.WriteLine("There is no students to assign the tasks. Please, add new student at first...");
                    break;
                }
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
