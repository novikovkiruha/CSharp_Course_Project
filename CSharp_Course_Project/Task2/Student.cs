using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Course_Project.Task2
{
    public class Student : User
    {
        public int Scholarship { get; set; }
        public int Course { get; set; }
 
        public Student(string name, int age, int scholarship, int course)
            : base(name, age)
        {
            Scholarship = scholarship;
            Course = course;
        }
    }
}
