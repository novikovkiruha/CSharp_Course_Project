using System;

namespace CSharp_Course_Project.Task1
{
    public class Worker
    {
        private int age;

        public string Name { get; set; }

        public decimal Salary { get; set; }

        public Worker(string name, int age, decimal salary)
        {
            Name = name;
            Age = age;
            Salary = salary;
        }

        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if (value >= 1 && value <= 100)
                    age = value;
                else
                    throw new ArgumentException("Incorrect age of {Name}");
            }
        }
    }
}
