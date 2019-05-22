using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Course_Project.Task2
{
    public class PrintUser
    {
        public void Execute()
        {
            var worker1 = new Worker("Sanya", 24, 7300);
            var worker2 = new Worker("Kirill", 28, 12000);
            var driver = new Driver("Pasha", 28, 12500, 2, DriverCategory.A);

            decimal salarySum = worker1.Salary + worker2.Salary;
            Console.WriteLine($"Sum of salary Ivan and Kirill = {salarySum}");
            Console.WriteLine($"Driver info: \n{driver.Name}\n{driver.Age}\n{driver.DriverExperience}\n{driver.DriverCategory}");
        }
    }
}
