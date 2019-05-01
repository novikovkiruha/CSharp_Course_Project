using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Course_Project.Task4
{
    class PupilList
    {
        public void Execute()
        {
            //Pupil pupil1 = new Pupil("Kirill", "Novikov", 28, 15, "11-A");
            //Console.WriteLine(pupil1.GetName());
            //Console.WriteLine(pupil1.GetSurname());
            //Console.WriteLine(String.Format($"{0,6} {1,15}\n\n", "Year", "Population"));

            Pupil[] pupils = new Pupil[1];

            for (int i = 0; i < pupils.Length; i++)
            {
                pupils[i] = new Pupil();

                Console.Write("Name: "); 
                pupils[i].SetName(Console.ReadLine());
                Console.Write("SurName: ");
                pupils[i].SetSurname(Console.ReadLine());
                Console.Write("Age: ");
                pupils[i].SetAge(int.Parse(Console.ReadLine()));
            }
        }
    }
}
