using System;
using System.Collections.Generic;
using System.Linq;

namespace practice_06._28._2019_delegates.Task2_DeferedInitialization
{

    public class DeferedInitialization
    {
        public void DeferedExample()
        {
            var employees = EmployeeList.GetEmployees().ToList();
            var maleEmployees = employees.Where(employee => employee.Gender == Gender.Male);
            Display(maleEmployees);
            employees.Add(new Employee { Id = 3, Name = "Rob", Surname = "Stark", Gender = Gender.Male });
            Display(maleEmployees);
        }

        void Display(IEnumerable<Employee> employees)
        {
            foreach (var employee in employees)
                Console.WriteLine($"{employee.Name} {employee.Surname}");
            Console.WriteLine();
        }
    }
}
