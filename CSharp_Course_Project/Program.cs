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
            //RangeNumber();
            //Translator();
            EmployeeBonus();
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

            //int sum = operand1 + operand2;
            //int subtraction = operand1 - operand2;
            //int multiply = operand1 * operand2;
            //int division = operand1 / operand2;

            int result = 0;

            switch (symbol)
            {
                case "+":
                    result = operand1 + operand2;
                    break;
                case "-":
                    result = operand1 - operand2;
                    break;
                case "*":
                    result = operand1 * operand2;
                    break;
                case "/":
                    if (operand2 != 0)
                    {
                        result = operand1 / operand2;
                    }
                    else
                    {
                        Console.WriteLine("Cann't divide by 0");
                    }
                    break;
                default:
                    break;
            }

            Console.WriteLine(result);

            //switch (symbol)
            //{
            //    case "+":
            //        Console.WriteLine(sum);
            //        break;
            //    case "-":
            //        Console.WriteLine(subtraction);
            //        break;
            //    case "*":
            //        Console.WriteLine(multiply);
            //        break;
            //    case "/":
            //        if (operand2 != 0)
            //        {
            //            Console.WriteLine(division);

            //        }
            //        else
            //        {
            //            Console.WriteLine("Cann't divide by 0");
            //        }
            //        break;
            //    default:
            //        break;
            //}
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
                Console.WriteLine($"{number} is between [36-50] and [50-100]");
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

        public static void Translator()
        {
            string word = Console.ReadLine();

            const string RussianWord1 = "погода";
            const string RussianWord2 = "тепло";
            const string RussianWord3 = "холодно";
            const string RussianWord4 = "ветер";
            const string RussianWord5 = "дождь";

            const string EnglishWord1 = "weather";
            const string EnglishWord2 = "warm";
            const string EnglishWord3 = "cold";
            const string EnglishWord4 = "wind";
            const string EnglishWord5 = "rain";

            switch (word)
            {
                case RussianWord1:
                    Console.WriteLine(EnglishWord1);
                    break;
                case RussianWord2:
                    Console.WriteLine(EnglishWord2);
                    break;
                case RussianWord3:
                    Console.WriteLine(EnglishWord3);
                    break;
                case RussianWord4:
                    Console.WriteLine(EnglishWord4);
                    break;
                case RussianWord5:
                    Console.WriteLine(EnglishWord5);
                    break;
                default:
                    Console.WriteLine("There is no such word. Please, enter another one.");
                    break;
            }
        }

        public static void EmployeeBonus()
        {
            Console.WriteLine("Enter employee experience:");
            int years = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter employee salary:");
            int salary = Convert.ToInt32(Console.ReadLine());
            double salaryWithBonus = 0;

            if (years < 5)
            {
                salaryWithBonus = salary * 1.1;
            }
            else if (years >= 5 && years < 10)
            {
                salaryWithBonus = salary * 1.15;
            }
            else if (years >= 10 && years < 15)
            {
                salaryWithBonus = salary * 1.25;
            }
            else if (years >= 15 && years < 20)
            {
                salaryWithBonus = salary * 1.35;
            }
            else if (years >= 20 && years < 25)
            {
                salaryWithBonus = salary * 1.45;
            }
            else if (years >= 25)
            {
                salaryWithBonus = salary * 1.5;
            }
            Console.WriteLine($"Employee salary with bonus - {salaryWithBonus}");
        }
    }
}