using System;
using System.Collections.Generic;

namespace practice_06._28._2019_delegates.Task2_DeferedInitialization
{
    public class Employee : IEquatable<Employee>
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

        public bool Equals(Employee employee)
        {
            if (Object.ReferenceEquals(employee, null))
                return false;

            if (Object.ReferenceEquals(this, employee))
                return true;

            return this.Name.Equals(employee.Name) &&
               this.Surname.Equals(employee.Surname);
        }
    }

    public class EmployeeComparer : IEqualityComparer<Employee>
    {
        public bool Equals(Employee employee1, Employee employee2)
        {
            return employee1.Name.ToString().ToUpper() == employee2.Name.ToString().ToUpper() && employee1.Surname.ToString().ToUpper() == employee2.Surname.ToString().ToUpper();
        }

        public int GetHashCode(Employee obj)
        {
            return obj.Id.GetHashCode();
        }
    }
}