using System;

namespace CSharp_Course_Project.Task1
{
    static class SalaryAndAge
    {
        public static void Execute()
        {
            Worker worker1 = new Worker("Sanya", 24, 7300);
            Worker worker2 = new Worker("Kirill", 28, 12000);
            decimal salarySum = worker1.Salary + worker2.Salary;
            int ageSum = worker1.Age + worker2.Age;

            Console.WriteLine($"Salary of {worker1.Name} = {worker1.Salary}");
            Console.WriteLine($"Salary of {worker2.Name} = {worker2.Salary}");
            Console.WriteLine($"Sum of salaries = {salarySum}");

            Console.WriteLine($"Age of {worker1.Name} = {worker1.Age}");
            Console.WriteLine($"Age of {worker2.Name} = {worker2.Age}");
            Console.WriteLine($"Sum of ages = {ageSum}");
        }
    }
}
