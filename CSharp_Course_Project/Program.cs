using System;

namespace CSharp_Course_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            SecondsAndHours();
        }

        public static void SecondsAndHours()
        {
            int seconds = Convert.ToInt32(Console.ReadLine());
            double hours = (double)seconds / 3600;
            Console.WriteLine(hours);
        }
    }
}