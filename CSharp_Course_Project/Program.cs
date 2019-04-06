using System;

namespace CSharp_Course_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            //SecondsAndHours();
            //ThreeNumbers();
            OddAndThreeDigitNumber();
        }

        public static void SecondsAndHours()
        {
            int seconds = Convert.ToInt32(Console.ReadLine());
            int hours = seconds / 3600;
            Console.WriteLine(hours);
        }

        public static void ThreeNumbers()
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());

            if ((b > a && b < c) || (b > c && b < a))
            {
                Console.WriteLine("B is between A and C");
            }
            else
            {
                Console.WriteLine("B is not betweeen A and C");
            }
        }

        public static void OddAndThreeDigitNumber()
        {
            string n = Console.ReadLine();
            int number = Convert.ToInt32(n);

            if (n.Length == 3 && number % 2 != 0)
            {
                Console.WriteLine($"{number} is odd and 3-digit number");
            }
            else
            {
                Console.WriteLine($"{number} is not odd and 3-digit number");
            }
        }
    }
}