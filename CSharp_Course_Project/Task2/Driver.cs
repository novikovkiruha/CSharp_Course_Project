using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Course_Project.Task2
{
    public class Driver : Worker
    {
        public double DriverExperience { get; set; }
        public DriverCategory DriverCategory { get; set; }

        public Driver(string name, int age, decimal salary, double driverExp, DriverCategory driverCategory)
         :base(name, age, salary)
        {
            DriverExperience = driverExp;
            DriverCategory = driverCategory;
        }
    }

    public enum DriverCategory
    {
        A,
        B,
        C
    }
}
