using System;

namespace CSharp_Course_Project.Task2
{
    public class User
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public User(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
}