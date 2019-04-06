using System;

namespace CSharp_Course_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            //SecondsAndHours();
            //ThreeNumbers();
            //OddAndThreeDigitNumber();
            //ThreeNumbersOperations();
            //ConsoleCalculator();
            RangeNumber();
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

        public static void ThreeNumbersOperations()
        {
            int x = 10, y = 12, z = 3;
            x += y - x++ * z; // 10 + 12 - (10 * 3)
            Console.WriteLine(x); //-8
            z = --x - y * 5; // -9 - (12 * 5)
            Console.WriteLine(z);
            y /= x + 5 % z;
            Console.WriteLine(y);
            z = x++ + y * 5;
            Console.WriteLine(z);
            x = y - x++ * z;
            Console.WriteLine(x);
        }

        public static void ConsoleCalculator()
        {
            Console.Write("Enter the first number: ");
            int operand1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the second number: ");
            int operand2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the operation symbol: ");
            string symbol = Console.ReadLine();

            int sum = operand1 + operand2;
            int subtraction = operand1 - operand2;
            int multiply = operand1 * operand2;
            int division = operand1 / operand2;

            switch (symbol)
            {
                case "+":
                    Console.WriteLine(sum);
                    break;
                case "-":
                    Console.WriteLine(subtraction);
                    break;
                case "*":
                    Console.WriteLine(multiply);
                    break;
                case "/":
                    if (operand2 != 0)
                    {
                        Console.WriteLine(division);
                        
                    }
                    else
                    {
                        Console.WriteLine("Cann't divide by 0");
                    }
                    break;
                default:
                    break;
            }
        }

        public static void RangeNumber()
        {
            int number = Convert.ToInt32(Console.ReadLine());

            if (number >= 0 && number <= 14)
            {
                Console.WriteLine($"{number} is between [0-14]");
            }
            else if (number >= 15 && number <= 35)
            {
                Console.WriteLine($"{number} is between [15-35]");
            }
            else if (number == 50)
            {
                Console.WriteLine($"{number} is 50");
            }
            else if (number >= 36 && number < 50)
            {
                Console.WriteLine($"{number} is between [36-50]");
            }
            else if (number > 50 && number <= 100)
            {
                Console.WriteLine($"{number} is between [50-100]");
            }
            else
            {
                Console.WriteLine($"{number} is between other ranges");
            }
        }
    }
}