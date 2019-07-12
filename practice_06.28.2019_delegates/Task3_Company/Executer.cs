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

            // 1
            var sortedEmployeesByName = employees.OrderBy(employee => employee.Name).ThenBy(employee => employee.Surname).ToList();
            //Display(sortedEmployeesByName);

            // 2
            var employeesByAge = employees.Where(employee => employee.Age > 30);
            //Display(employeesByAge);

            // 3
            var menEmployees = employees.Where(employee => employee.Gender == Gender.Male);
            //Display(menEmployees);
            //var womenEmployees = employees.Where(employee => employee.Gender == Gender.Female);
            //Display(womenEmployees);

            // 4
            var companyEmployees = employees.Select(employee => $"{employee.Name} {employee.Surname}").ToArray();
            //Display(companyEmployees);

            // 5
            var womenEmployeesByNameAndAge = employees.Where(employee =>
                        employee.Gender == Gender.Female
                        && employee.Name.StartsWith("S")
                        && employee.Age > 20);
            //Display(womenEmployeesByNameAndAge);

            // 6
            var employeeNumber = employees.GroupBy(employee => employee.Company).Select(employee => employee.Count()).ToList();
            //int count = 1;
            //foreach (var item in employeeNumber)
            //{
            //    Console.WriteLine($"Company {count}: {item} employees");
            //    count++;
            //}

            // 7
            //Console.WriteLine(employees.First().ToString());
            // 8
            //Console.WriteLine(employees.Last().ToString());
            // 9
            //var firstEmployee = employees.Where(employee => employee.Age < 25).First();
            //Console.WriteLine(firstEmployee);

            // 10
            var newPupil = employees
                .Where(employee => employee.Name.Equals("Tirion"))
                .Select(pupil => new Pupil(name: pupil.Name, surname: pupil.Surname, school: "Fucking School")).ToList();
            foreach (var pupil in newPupil)
            {
                Console.WriteLine(pupil.ToString());
            }
        }

        public void Display(IEnumerable<Employee> employees)
        {
            foreach (var employee in employees)
                Console.WriteLine($"Person: {employee.Name} {employee.Surname}{Environment.NewLine}" +
                    $"Age: {employee.Age}{Environment.NewLine}" +
                    $"Gender: {employee.Gender}{Environment.NewLine}" +
                    $"Company: {employee.Company}{Environment.NewLine}");
            Console.WriteLine();
        }

        public void Display(string[] fullNames)
        {
            foreach (var fullName in fullNames)
                Console.WriteLine($"{fullName}{Environment.NewLine}");
            Console.WriteLine();
        }
    }
}
