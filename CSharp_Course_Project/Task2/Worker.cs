using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Course_Project.Task2
{
    public class Worker : User
    {
        private decimal salary;

        public Worker(string name, int age, decimal salary) 
            :base(name, age)
        {
            this.salary = salary;
        }

        public decimal Salary
        {
            get
            {
                return salary;
            }
            set
            {
                if (value > 0)
                    salary = value;
                else
                    throw new ArgumentException("Salary can't be less or equal to 0");
            }
        }
    }
}
