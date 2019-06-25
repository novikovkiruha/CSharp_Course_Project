using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Course_Project.Task2_StudentDictionary
{
    public class StudentDictionary
    {
        internal readonly Dictionary<string, string> students = new Dictionary<string, string>();
        public void AddStudent()
        {
            //while (true)
            //{
            //    Console.Write("Please enter a student name: ");
            //    var name = Console.ReadLine();

            //    Console.Write("Please enter a student surname: ");
            //    var surname = Console.ReadLine();

            //    Console.Write("Please enter a student course (1-5): ");
            //    var course = Byte.TryParse(Console.ReadLine(), out byte courseNumber);

            //    Console.Write("Please enter a student group: ");
            //    var group = Console.ReadLine();

            //    Console.Write("Please enter a student faculty: ");
            //    var faculty = Console.ReadLine();

            //    //var name = "name1";
            //    //var surname = "surname1";
            //    //byte courseNumber = 2;
            //    //var group = "C";
            //    //var faculty = "Ec";

            //    students.Add(new Student(name + surname, courseNumber, group, faculty));

            //    Console.WriteLine("Do you want to add one more student? Y/N");
            //    var addingResult = Console.ReadLine();
            //    if (addingResult.ToLower() == "y")
            //        continue;
            //    else
            //    {
            //        foreach (var item in students)
            //            Console.WriteLine(item.ToString());
            //        break;
            //    }
            //}
        }
    }
}
