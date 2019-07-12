using practice_06._28._2019_delegates.Task2_DeferedInitialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice_06._28._2019_delegates.Task4_JoinEmployees
{
    public class EmployeeListJoiner
    {
        public void JoinEmployeeLists()
        {
            var inteticsEmployees = EmployeeList.GetInteticsEmployees();
            var companyEmployees = EmployeeList.GetGoTEmployees();

            var employeesWithDuplicates = inteticsEmployees.Union(companyEmployees);

            var counter = 1;
            Console.WriteLine("Employee list with duplicates:");
            foreach (var employee in employeesWithDuplicates)
            {
                Console.WriteLine($"{counter}: {employee.ToString()}");
                counter++;
            }
            Console.WriteLine($"Total number of employees: {employeesWithDuplicates.Count()}{Environment.NewLine}");

            //var employeesWithoutDuplicates = inteticsEmployees.Concat(companyEmployees).GroupBy(employee => employee.Name).Select(employee => employee.First());
            var employeesWithoutDuplicates = employeesWithDuplicates.Distinct(new EmployeeComparer());

            counter = 1;
            Console.WriteLine("Employee list without duplicates:");
            foreach (var employee in employeesWithoutDuplicates)
            {
                Console.WriteLine($"{counter}: {employee.ToString()}");
                counter++;
            }
            Console.WriteLine($"Total number of employees: {employeesWithoutDuplicates.Count()}{Environment.NewLine}");

            counter = 1;
            var duplicatedEmployees = inteticsEmployees.Intersect(companyEmployees, new EmployeeComparer());
            Console.WriteLine("Only duplicated employees:");
            foreach (var employee in duplicatedEmployees)
            {
                Console.WriteLine($"{counter}: {employee.ToString()}");
                counter++;
            }
            Console.WriteLine($"Total number of employees: {duplicatedEmployees.Count()}{Environment.NewLine}");

            counter = 1;
            var newEmployees = employeesWithoutDuplicates.ToList();
            newEmployees.Add(new Employee(31, "Maksim", "Evsukov", Gender.Male));
            Console.WriteLine("Only duplicated employees:");
            foreach (var employee in newEmployees)
            {
                Console.WriteLine($"{counter}: {employee.ToString()}");
                counter++;
            }
            Console.WriteLine($"Total number of employees: {newEmployees.Count()}{Environment.NewLine}");
        }
    }
}
