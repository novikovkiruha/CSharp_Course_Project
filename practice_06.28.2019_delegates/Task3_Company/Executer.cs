using practice_06._28._2019_delegates.Task2_DeferedInitialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice_06._28._2019_delegates.Task3_Company
{
    public class Executer
    {
        public void Execute()
        {
            var employees = EmployeeList.GetCompanyEmployees();

            //var sortedEmployeesByName = employees.OrderBy(employee => employee.Name).ToList();
            //Display(sortedEmployeesByName);

            //var employeesByAge = employees.Where(employee => employee.Age > 30);
            //Display(employeesByAge);

            //var menEmployees = employees.Where(employee => employee.Gender == Gender.Male);
            //Display(menEmployees);
            //var womenEmployees = employees.Where(employee => employee.Gender == Gender.Female);
            //Display(womenEmployees);

            //var companyEmployees = employees.Select(employee => $"{employee.Name} {employee.Surname}");
            //foreach (var employee in companyEmployees)
            //{
            //    Console.WriteLine(employee);
            //}

            //var womenEmployeesByNameAndAge = employees.Where(employee =>
            //                                                        employee.Gender == Gender.Female
            //                                                        && employee.Name.StartsWith("S")
            //                                                        && employee.Age > 20);
            //Display(womenEmployeesByNameAndAge);

            var employeeNumber = employees.GroupBy(employee => employee.Company);
            foreach (var item in employeeNumber)
            {
                Console.WriteLine(item);
            }
        }

        void Display(IEnumerable<Employee> employees)
        {
            foreach (var employee in employees)
                Console.WriteLine($"Person: {employee.Name} {employee.Surname}{Environment.NewLine}" +
                    $"Age: {employee.Age}{Environment.NewLine}" +
                    $"Gender: {employee.Gender}{Environment.NewLine}" +
                    $"Company: {employee.Company}{Environment.NewLine}");
            Console.WriteLine();
        }
    }
}
