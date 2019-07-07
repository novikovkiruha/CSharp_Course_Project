using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice_06._28._2019_delegates.Task2_DeferedInitialization
{
    public class UndeferedInitialization
    {
        public void UndeferedExample()
        {
            var employees = EmployeeList.GetEmployees();
            var maleEmployees = employees.Where(employee => employee.Gender == Gender.Male).ToList();
            Display(maleEmployees);
            employees.Add(new Employee { ID = 3, Name = "Rob", Surname = "Stark", Gender = Gender.Male });
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
