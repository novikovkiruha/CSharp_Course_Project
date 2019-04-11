using System;

namespace CSharp_Course_Project
{
    class Program
    {
        public static void MaxDigit() // 17
        {
            while (true)
            {
                Console.Write("Enter the number: ");
                string stringNumber = Console.ReadLine();
                bool isNumber = Int32.TryParse(stringNumber, out int number);
                if (!isNumber || number < 0)
                {
                    Console.WriteLine("Not a numeric or natural value. Try again...");
                    continue;
                }
                int max = 0;
                for (int i = 0; i < stringNumber.Length; i++)
                {
                    int temp = number % 10;
                    if (temp > max) max = temp;
                    number /= 10;
                }
                Console.WriteLine(max);

                Console.WriteLine("Would you like to continue? Y/N");
                string proceed = Console.ReadLine();
                if (proceed.ToLower() == "n") break;
                else continue;
            }
        }

        public static void CollatzConjecture() // 18
        {
            while (true)
            {
                Console.Write("Enter the number: ");
                string stringNumber = Console.ReadLine();
                bool isNumber = Int32.TryParse(stringNumber, out int number);
                if (!isNumber || number < 0)
                {
                    Console.WriteLine("Not a numeric or natural value. Try again...");
                    continue;
                }
                while (number > 1)
                {
                    Console.WriteLine(number);
                    if (number % 2 == 0)
                    {
                        number /= 2;
                    }
                    else if (number % 2 != 0)
                    {
                        number *= 3;
                        number += 1;
                    }
                    Console.WriteLine(number);
                }

                Console.WriteLine("Would you like to continue? Y/N");
                string proceed = Console.ReadLine();
                if (proceed.ToLower() == "n") break;
                else continue;
            }
        }

        public static void RandomNumberGuessing() // 19
        {
            while (true)
            {
                var random = new Random().Next(0, 100);
                while (true)
                {
                    Console.Write("Try to guess a number in range 0 and 100: ");
                    string stringNumber = Console.ReadLine();
                    bool isNumber = Int32.TryParse(stringNumber, out int number);
                    if (!isNumber || number < 0)
                    {
                        Console.WriteLine("Not a numeric or natural value. Try again...");
                        continue;
                    }

                    if (number > random)
                    {
                        Console.WriteLine("You're close, but entered number should be less");
                        continue;
                    }
                    else if (number < random)
                    {
                        Console.WriteLine("You're close, but entered number should be bigger");
                        continue;
                    }
                    else
                    {
                        Console.WriteLine($"You're right! The random number is {random}");
                        break;
                    }
                }
                break;
            }
        }

        static void Main(string[] args)
        {
            //MaxDigit();
            //CollatzConjecture();
            RandomNumberGuessing();
        }
    }
}