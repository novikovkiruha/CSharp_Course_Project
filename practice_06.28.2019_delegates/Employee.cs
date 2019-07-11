using System.Collections.Generic;

namespace practice_06._28._2019_delegates.Task2_DeferedInitialization
{
    public class Employee
    {
        public int Id { get; set; }

        public int Age { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public string Company { get; set; }

        public Gender Gender { get; set; }

        public Employee()
        {

        }

        public Employee(int id, string name, string surname, Gender gender)
        {
            this.Id = id;
            this.Name = name;
            this.Surname = surname;
            this.Gender = gender;
        }

        public Employee(int id, string name, string surname, Gender gender, int age, string company)
        {
            this.Id = id;
            this.Name = name;
            this.Surname = surname;
            this.Gender = gender;
            this.Age = age;
            this.Company = company;
        }

        public override string ToString()
        {
            return $"{this.Name} {this.Surname}";
        }
    }
}
