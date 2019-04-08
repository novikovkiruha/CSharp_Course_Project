using System;

namespace CSharp_Course_Project
{
    class Program
    {
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
            while (true)
            {
                Console.Write("Enter the first number: ");
                string op1 = Console.ReadLine();
                bool isFirstNumber = Int32.TryParse(op1, out int operand1);
                Console.Write("Enter the second number: ");
                string op2 = Console.ReadLine();
                bool isSecondNumber = Int32.TryParse(op2, out int operand2);
                Console.Write("Enter the operation symbol: ");
                string symbol = Console.ReadLine();

                if (!isFirstNumber || !isSecondNumber)
                {
                    Console.WriteLine("Entered numbers are not numberic values. Try again: ");
                    continue;
                }
                else if (operand2 == 0 && symbol == "/")
                {
                    Console.WriteLine("Сannot divide by 0. Try again:");
                    continue;
                }
                else
                {
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
                            result = operand1 / operand2;
                            break;
                        default:
                            Console.WriteLine("Wrong operation symbol. Try again:");
                            continue;
                    }
                    Console.WriteLine(result);
                }
                Console.WriteLine("Do you want to proceed? Y/N");
                string proceed = Console.ReadLine();
                if (proceed == "N" || proceed == "n")
                {
                    break;
                }
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

        public static void Factrorial()
        {
            int number = Convert.ToInt32(Console.ReadLine());
            int factorial = 1;

            for (int i = 1; i < number; i++)
            {
                factorial *= i + 1;
            }
            Console.WriteLine(factorial);
        }

        public static void GeometricalFigures()
        {
            Console.WriteLine("Enter one of the figure from the list:\n" +
                "'S' for String\n" +
                "'R' for Rectangle\n" +
                "'RT' for Right Triangle\n" +
                "'ET' for Equilateral Triangle\n" +
                "'RH' for Rhombus");
            string figure = Console.ReadLine();

            int i, j, k;

            if (figure == "string" || figure == "String" || figure == "S" || figure == "s")
            {
                Console.Write("Enter the length of a string: ");
                while (true)
                {
                    string stringLength = Console.ReadLine();
                    bool isLengthNumber = Int32.TryParse(stringLength, out int length);
                    if (!isLengthNumber || stringLength == "0")
                    {
                        Console.Write("Length is not a numeric value. Try again and enter the length of a string: ");
                        continue;
                    }
                    else
                    {
                        for (i = 0; i < length; i++)
                        {
                            Console.Write("*");
                        }
                        Console.WriteLine();
                        break;
                    }
                }
            }
            else if (figure == "rectangle" || figure == "Rectangle" || figure == "R" || figure == "r")
            {
                Console.WriteLine("Enter the length and height of a rectangle: ");

                while (true)
                {
                    string stringLength = Console.ReadLine();
                    string stringHeight = Console.ReadLine();
                    bool isLengthNumber = Int32.TryParse(stringLength, out int length);
                    bool isHeightNumber = Int32.TryParse(stringHeight, out int height);

                    if ((!isLengthNumber || stringLength == "0") || (!isHeightNumber || stringHeight == "0"))
                    {
                        Console.WriteLine("Length or height is not a numeric value. Try again and enter the length and height of a rectangle: ");
                        continue;
                    }
                    else
                    {
                        for (i = 0; i < height; i++)
                        {
                            for (j = 0; j < length; j++)
                            {
                                Console.Write("*");
                            }
                            Console.Write("\n");
                        }
                        break;
                    }
                }
            }
            else if (figure == "right triangle" || figure == "Right Triangle" || figure == "RT" || figure == "rt")
            {
                Console.Write("Enter the base length of a right triangle: ");

                while (true)
                {
                    string stringLength = Console.ReadLine();
                    bool isLengthNumber = Int32.TryParse(stringLength, out int length);

                    if (!isLengthNumber || stringLength == "0")
                    {
                        Console.Write("Length is not a numeric value. Try again and enter the length of a right triangle: ");
                        continue;
                    }
                    else
                    {
                        for (i = 1; i <= length; i++)
                        {
                            for (j = 1; j <= i; j++)
                            {
                                Console.Write("*");
                            }
                            Console.Write("\n");
                        }
                        break;
                    }
                }
            }
            else if (figure == "equilateral triangle" || figure == "Equilateral Triangle" || figure == "ET" || figure == "et")
            {
                Console.Write("Enter the side length of a equilateral triangle: ");
                while (true)
                {
                    string stringLength = Console.ReadLine();
                    bool isLengthNumber = Int32.TryParse(stringLength, out int length);

                    if (!isLengthNumber || stringLength == "0")
                    {
                        Console.Write("Length is not a numeric value. Try again and enter the length of a equilateral triangle: ");
                        continue;
                    }
                    else
                    {
                        for (i = 1; i <= length; i += 2)
                        {
                            for (k = length; k > i; k -= 2)
                            {
                                Console.Write(" ");
                            }
                            for (j = 0; j < i; j++)
                            {
                                Console.Write("*");
                            }
                            Console.Write("\n");
                        }
                        break;
                    }
                }
            }
            else if (figure == "rhombus" || figure == "Rhombus" || figure == "RH" || figure == "rh")
            {
                Console.Write("Enter the diagonal length of a rhombus: ");
                while (true)
                {
                    string stringDiagonal = Console.ReadLine();
                    bool isDiagonalNumber = Int32.TryParse(stringDiagonal, out int length);

                    if (!isDiagonalNumber || stringDiagonal == "0")
                    {
                        Console.Write("Diagonal is not a numeric value. Try again and enter the diagonal of a rhombus: ");
                        continue;
                    }
                    else
                    {
                        if (length % 2 == 0)
                        {
                            for (i = 1; i <= length; i += 2)
                            {
                                for (k = length; k > i; k -= 2)
                                {
                                    Console.Write(" ");
                                }
                                for (j = 0; j < i; j++)
                                {
                                    Console.Write("*");
                                }
                                Console.Write("\n");
                            }
                            for (i = length-1; i >= 1; i -= 2)
                            {
                                for (k = length; k > i; k -= 2)
                                {
                                    Console.Write(" ");
                                }
                                for (j = 0; j < i; j++)
                                {
                                    Console.Write("*");
                                }
                                Console.Write("\n");
                            }
                        }
                        else
                        {
                            for (i = 1; i <= length; i += 2)
                            {
                                for (k = length; k > i; k -= 2)
                                {
                                    Console.Write(" ");
                                }
                                for (j = 0; j < i; j++)
                                {
                                    Console.Write("*");
                                }
                                Console.Write("\n");
                            }
                            for (i = length; i >= 0; i -= 2)
                            {
                                for (k = length; k > i; k -= 2)
                                {
                                    Console.Write(" ");
                                }
                                for (j = 0; j < i; j++)
                                {
                                    Console.Write("*");
                                }
                                Console.Write("\n");
                            }
                        }
                        
                        break;
                    }
                }
            }
        }

        public static void NumberProcesses()
        {
            string n = Console.ReadLine();
            int number = Convert.ToInt32(n);

            if (number == 0)
                Console.WriteLine($"Number is 0");
            else if (number < 0)
                Console.WriteLine("Number is negative");
            else if (number > 0)
                Console.WriteLine("Number is positive");
        }

        static void Main(string[] args)
        {
            //SecondsAndHours();
            //ThreeNumbers();
            //OddAndThreeDigitNumber();
            //ThreeNumbersOperations();
            //ConsoleCalculator();
            //RangeNumber();
            //Translator();
            //EmployeeBonus();
            //Factrorial();
            //NumberProcesses();
            GeometricalFigures();
        }
    }
}