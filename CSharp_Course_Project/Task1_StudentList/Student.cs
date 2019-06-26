using System;
using System.Collections.Generic;

namespace CSharp_Course_Project.Task1_StudentList
{
    public class Student
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public byte Course { get; set; }
        public string Group { get; set; }
        public string Faculty { get; set; }

        public Student(string name, string surname, byte course, string group, string faculty)
        {
            this.Name = name;
            this.Surname = surname;
            this.Course = course;
            this.Group = group;
            this.Faculty = faculty;
        }

        public override string ToString()
        {
            return $"Name: {this.Name}{Environment.NewLine}" +
                $"Surname: {this.Surname}{Environment.NewLine}" +
                $"Course: {this.Course}{Environment.NewLine}" +
                $"Group: {this.Group}{Environment.NewLine}" +
                $"Faculty: {this.Faculty}{Environment.NewLine}";
        }
    }
}
