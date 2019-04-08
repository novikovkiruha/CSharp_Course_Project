using System;

namespace CSharp_Course_Project
{
    class Program
    {
        public static void NumberProcesses()
        {
            while (true)
            {
                Console.Write("Enter the number: ");
                string stringNumber = Console.ReadLine();
                bool isNumber = Int32.TryParse(stringNumber, out int number);

                if (!isNumber)
                {
                    Console.WriteLine("Not a numeric value. Try again...");
                    continue;
                }

                if (number == 0)
                    Console.WriteLine($"Number is 0");
                else if (number < 0)
                    Console.WriteLine("Negative number");
                else if (number > 0)
                    Console.WriteLine("Positive number");

                int count = 0;
                for (int i = 1; i <= number; i++)
                {
                    if (number % i == 0)
                    {
                        count++;
                    }
                }
                if (count == 2)
                    Console.WriteLine($"{number} is a prime number");
                else
                    Console.WriteLine($"{number} is NOT a prime number");

                int[] array = new int[5] { 9, 5, 3, 6, 9 }; // 0 = 2, 1 = 5, 2 = 3
                for (int i = 0; i < array.Length; i++)
                {
                    if (number % array[i] == 0)
                    {
                        Console.WriteLine($"The number is divided by {array[i]}");
                    }
                }
                continue;
            }
        }

        static void Main(string[] args)
        {
            NumberProcesses();
        }
    }
}