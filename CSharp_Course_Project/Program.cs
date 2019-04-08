using System;

namespace CSharp_Course_Project
{
    class Program
    {
        public static void NumberProcesses()
        {
            string n = Console.ReadLine();
            int number = Convert.ToInt32(n);

            if (number == 0)
                Console.WriteLine($"Number is 0");
            else if (number < 0)
                Console.WriteLine("Negative number");
            else if (number > 0)
                Console.WriteLine("Positive number");

            //int primeNumber = number;
            //for (int i = 1; i <= number; i++)
            //{
            //    if (i / number == 1 && number / 1 == number)
            //        primeNumber = number;
            //}
            //Console.WriteLine($"{number} is a prime number");

            int[] array = new int[5] { 9, 5, 3, 6, 9 }; // 0 = 2, 1 = 5, 2 = 3
            for (int i = 0; i < array.Length; i++)
            {
                if (number % array[i] == 0)
                {
                    Console.WriteLine($"The number is divided by {array[i]}");
                }
            }
        }

        static void Main(string[] args)
        {
            NumberProcesses();
        }
    }
}