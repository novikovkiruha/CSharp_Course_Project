using CSharp_Course_Project.Task4_Stack;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp_Course_Project.Task1_StudentList
{
    public class Student
    {
        private string name;

        private string surname;

        private byte course;

        private string group;

        private string faculty;

        private readonly Stack<string> bookList;

        public Queue<string> TaskList { get; set; }

        public Student(string name, string surname, byte course, string group, string faculty)
        {
            this.Name = name;
            this.Surname = surname;
            this.Course = course;
            this.Group = group;
            this.Faculty = faculty;
            this.bookList = new Stack<string>();
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    this.name = value;
                else
                    throw new NullReferenceException("Name can't be blank");
            }
        }

        public string Surname
        {
            get { return this.surname; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    this.surname = value;
                else
                    throw new NullReferenceException("Surname can't be blank");
            }
        }

        public byte Course
        {

            get { return this.course; }
            set
            {
                if (value != 0)
                    this.course = value;
                else
                    throw new ArgumentException("Course can't be equal to 0");
            }
        }

        public string Group
        {
            get { return this.group; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    this.group = value;
                else
                    throw new NullReferenceException("Surname can't be blank");
            }
        }

        public string Faculty
        {
            get { return this.faculty; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    this.faculty = value;
                else
                    throw new NullReferenceException("Surname can't be blank");
            }
        }

        public void CompleteTaskList(Queue<string> tasks)
        {
            this.TaskList = tasks;
            foreach (var task in this.TaskList)
            {
                Console.WriteLine($"{task} task is done by {this.Name} {this.Surname}");
            }
            //this.TaskList.Dequeue();
        }

        public void TakeLibraryBook()
        {
            this.bookList.Push(new BookLibrary().GiveBook());

            foreach (var item in this.bookList)
            {
                Console.WriteLine(item);
            }
        }

        public void ReturnLibraryBook()
        {
            string returnedBook = string.Empty;

            if (this.bookList.Any())
                returnedBook = this.bookList.Pop();
            else
                Console.WriteLine($"{this.Name} {this.Surname} has no any book");
        }

        public override string ToString()
        {
            return $"Student: {this.Name} {this.Surname}{Environment.NewLine}" +
                $"Course: {this.Course}{Environment.NewLine}" +
                $"Group: {this.Group}{Environment.NewLine}" +
                $"Faculty: {this.Faculty}{Environment.NewLine}";
        }
    }
}
