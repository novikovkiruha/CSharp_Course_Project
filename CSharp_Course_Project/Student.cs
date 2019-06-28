using System;

namespace CSharp_Course_Project.Task1_StudentList
{
    public class Student
    {
        public string name;

        public string surname;

        public byte course;

        public string group;

        public string faculty;

        public Student(string name, string surname, byte course, string group, string faculty)
        {
            this.Name = name;
            this.Surname = surname;
            this.Course = course;
            this.Group = group;
            this.Faculty = faculty;
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (value != string.Empty)
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
                if (value != string.Empty)
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
                if (value != string.Empty)
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
                if (value != string.Empty)
                    this.faculty = value;
                else
                    throw new NullReferenceException("Surname can't be blank");
            }
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
