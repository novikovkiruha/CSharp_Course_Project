using System;

namespace CSharp_Course_Project
{
    class Program
    {
        public static void NumberProcesses() // 3
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
                {
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
                }

                int[] array = new int[5] { 9, 5, 3, 6, 9 }; // 0 = 2, 1 = 5, 2 = 3
                for (int i = 0; i < array.Length; i++)
                {
                    if (number % array[i] == 0)
                    {
                        Console.WriteLine($"The number is divided by {array[i]}");
                    }
                }
                Console.WriteLine("Do you want to proceed? Y/N");
                string proceed = Console.ReadLine();
                if (proceed.Equals("Y") || proceed.Equals("y"))
                    continue;
                else
                    break;
            }
        }

        public static void Logistics() // 4
        {
            while (true)
            {
                Console.Write("Enter the number of clients: ");
                string stringNumber = Console.ReadLine();
                bool isNumber = Int32.TryParse(stringNumber, out int clientsNumber);
                int routes = clientsNumber;
                if (!isNumber)
                {
                    Console.WriteLine("Not a numeric value. Try again...");
                    continue;
                }
                else if (clientsNumber == 0)
                {
                    Console.WriteLine("Number of clients cann't be 0. Try again...");
                    continue;
                }
                else if (clientsNumber == 1)
                {
                    Console.WriteLine($"Number of routes: {routes}");
                }
                else
                {
                    do
                    {
                        routes *= clientsNumber - 1;
                        clientsNumber--;
                    }
                    while (clientsNumber != 1);
                    Console.WriteLine($"Number of routes: {routes}");
                }
                Console.WriteLine("Do you want to proceed? Y/N");
                string proceed = Console.ReadLine();
                if (proceed.Equals("Y") || proceed.Equals("y"))
                    continue;
                else
                    break;
            }
        }

        public static void TwoNumbersAandB() // 5
        {
            while (true)
            {
                Console.WriteLine("Enter 2 numbers A and B:");
                string stringNumberA = Console.ReadLine();
                bool isNumberA = Int32.TryParse(stringNumberA, out int a);
                string stringNumberB = Console.ReadLine();
                bool isNumberB = Int32.TryParse(stringNumberB, out int b);

                if (!isNumberA || !isNumberB)
                {
                    Console.WriteLine("Not a numeric values. Try again...");
                    continue;
                }
                if (a < b)
                {
                    int sum = a;
                    sum -= a;
                    for (int i = a; i <= b; i++)
                    {
                        sum += i;
                        if (i % 2 != 0)
                        {
                            Console.WriteLine($"{i} is odd number");
                        }
                    }
                    Console.WriteLine($"Sum of numbers in range: {sum} ");
                }
                else
                {
                    Console.WriteLine("A should be less than B");
                    continue;
                }
                Console.WriteLine("Do you want to proceed? Y/N");
                string proceed = Console.ReadLine();
                if (proceed.Equals("Y") || proceed.Equals("y"))
                    continue;
                else
                    break;
            }
        }

        public static void EvenDigits() // 6
        {
            while (true)
            {
                Console.Write("Enter the number: ");
                string stringNumber = Console.ReadLine();
                bool isNumber = Int32.TryParse(stringNumber, out int number);

                if (!isNumber || number <= 0)
                {
                    Console.WriteLine("Not a numeric value or natural number. Try again...");
                    continue;
                }

                int temp = 0;
                int count = 0;
                for (int i = 0; i < stringNumber.Length; i++)
                {
                    temp = number % 10;
                    number /= 10;
                    if (temp % 2 == 0)
                        count++;
                }
                Console.WriteLine($"Number of even digits: {count}");

                Console.WriteLine("Do you want to proceed? Y/N");
                string proceed = Console.ReadLine();
                if (proceed.Equals("Y") || proceed.Equals("y"))
                    continue;
                else
                    break;
            }
        }

        public static void NumbersAverage() // 7
        {
            while (true)
            {
                Console.WriteLine("Enter 2 numbers A and B:");
                string stringNumberA = Console.ReadLine();
                bool isNumberA = Int32.TryParse(stringNumberA, out int a);
                string stringNumberB = Console.ReadLine();
                bool isNumberB = Int32.TryParse(stringNumberB, out int b);

                if (!isNumberA || !isNumberB)
                {
                    Console.WriteLine("Not a numeric values. Try again...");
                    continue;
                }
                if (a <= b)
                {
                    int sum = a;
                    sum -= a;
                    int count = 0;
                    for (int i = a; i <= b; i++)
                    {
                        sum += i;
                        count++;
                    }
                    double average = (double)sum / (double)count;
                    Console.WriteLine($"Average: {average}");
                }
                else
                {
                    Console.WriteLine("A should be less or equal to B");
                    continue;
                }
                Console.WriteLine("Do you want to proceed? Y/N");
                string proceed = Console.ReadLine();
                if (proceed.Equals("Y") || proceed.Equals("y"))
                    continue;
                else
                    break;
            }
        }

        public static void Skier() // 8
        {
            double dailyDistance = 10;
            int days = 1;
            double increment = 1.1;
            double kmMax = 100;
            double km = 0;
            while (km < kmMax)
            {
                dailyDistance *= increment;
                km += dailyDistance;
                days++;
                Console.WriteLine($"{dailyDistance} km in {days} days");
            }
        }

        public static void MultiplyOperation() // 9
        {
            while (true)
            {
                Console.WriteLine("Enter two numbers:");
                string stringNumber1 = Console.ReadLine();
                bool isNumber1 = Int32.TryParse(stringNumber1, out int number1);
                string stringNumber2 = Console.ReadLine();
                bool isNumber2 = Int32.TryParse(stringNumber2, out int number2);
                if (!isNumber1 || !isNumber2)
                {
                    Console.WriteLine("Not a numeric values. Try again...");
                    continue;
                }

                int result = 0;
                if (number1 >= 0 && number2 >= 0)
                {
                    for (int i = 0; i < number1; i++)
                    {
                        result += number2;
                    }
                }
                else if (number1 < 0)
                {
                    for (int i = 0; i < -number1; i++)
                    {
                        result += -number2;
                    }
                }
                else if (number2 < 0)
                {
                    for (int i = 0; i < -number2; i++)
                    {
                        result += -number1;
                    }
                }
                Console.WriteLine($"Multiply result: {result}");

                Console.WriteLine("Do you want to proceed? Y/N");
                string proceed = Console.ReadLine();
                if (proceed.Equals("N") || proceed.Equals("n"))
                    break;
                else
                    continue;
            }
        }

        public static void SquareNumber() // 10
        {
            while (true)
            {
                Console.Write("Enter the number: ");
                string stringNumber = Console.ReadLine();
                bool isNumber = Int32.TryParse(stringNumber, out int number);
                if (!isNumber || number <= 1)
                {
                    Console.WriteLine("Not a numeric, natural value or value is 1. Try again...");
                    continue;
                }

                int result = 0;
                for (int i = 1; i <= number; i++)
                {
                    result = i * i;
                    if (result <= number)
                        Console.WriteLine($"Square of {i} = {result}");
                }

                Console.WriteLine("Do you want to proceed? Y/N");
                string proceed = Console.ReadLine();
                if (proceed.Equals("N") || proceed.Equals("n"))
                    break;
                else
                    continue;
            }
        }

        public static void Fibonacci() // 11
        {
            while (true)
            {
                Console.Write("Enter the number: ");
                string stringNumber = Console.ReadLine();
                bool isNumber = Int32.TryParse(stringNumber, out int number);
                if (!isNumber || number < 0)
                {
                    Console.WriteLine("Not a numeric values or less than 0. Try again...");
                    continue;
                }
                int firstNumber = 0;
                int secondNumber = 1;
                int nextNumber = 0;
                while (nextNumber < number)
                {
                    Console.WriteLine(nextNumber);
                    firstNumber = secondNumber;
                    secondNumber = nextNumber;
                    nextNumber = firstNumber + secondNumber;
                }
                Console.WriteLine("Do you want to proceed? Y/N");
                string proceed = Console.ReadLine();
                if (proceed.Equals("N") || proceed.Equals("n"))
                    break;
                else
                    continue;
            }
        }

        public static void FibonacciAllNumbers() // 12
        {
            while (true)
            {
                Console.Write("Enter the number: ");
                string stringNumber = Console.ReadLine();
                bool isNumber = Int32.TryParse(stringNumber, out int number);
                if (!isNumber || number < 0)
                {
                    Console.WriteLine("Not a numeric values or less than 0. Try again...");
                    continue;
                }
                int firstNumber = 0;
                int secondNumber = 1;
                int nextNumber = 0;
                for (int i = 1; i <= number; i++)
                {
                    Console.WriteLine(firstNumber);
                    nextNumber = firstNumber + secondNumber;
                    firstNumber = secondNumber;
                    secondNumber = nextNumber;
                }
                Console.WriteLine("Do you want to proceed? Y/N");
                string proceed = Console.ReadLine();
                if (proceed.Equals("N") || proceed.Equals("n"))
                    break;
                else
                    continue;
            }
        }

        public static void InvertedNumber() // 13
        {
            while (true)
            {
                Console.Write("Enter the number: ");
                string stringNumber = Console.ReadLine();
                bool isNumber = Int32.TryParse(stringNumber, out int number);
                if (!isNumber || number < 0)
                {
                    Console.WriteLine("Not a numeric values or less than 0. Try again...");
                    continue;
                }
                int invertedNumber = 0;
                while (number > 0)
                {
                    // number 12345 1234 123 12
                    int remainder = number % 10; // 5 4 3 2 1
                    invertedNumber *= 10; // 0 50 40 30 20 10
                    invertedNumber += remainder; // 5 54 32
                    number /= 10; // 1234 123 12
                }
                Console.WriteLine(invertedNumber);

                Console.WriteLine("Do you want to proceed? Y/N");
                string proceed = Console.ReadLine();
                if (proceed.Equals("N") || proceed.Equals("n"))
                    break;
                else
                    continue;
            }
        }

        public static void NumberDigits() // 14
        {
            while (true)
            {
                Console.Write("Enter the number: ");
                string stringNumber = Console.ReadLine();
                bool isNumber = Int32.TryParse(stringNumber, out int number);
                if (!isNumber || number < 0)
                {
                    Console.WriteLine("Not a numeric values or less than 0. Try again...");
                    continue;
                }
                int[] array = new int[stringNumber.Length];
                for (int i = array.Length - 1; i >= 0; i--)
                {
                    array[i] = number % 10;
                    number /= 10;
                }
                foreach (var item in array)
                    Console.WriteLine(item);

                Console.WriteLine("Do you want to proceed? Y/N");
                string proceed = Console.ReadLine();
                if (proceed.Equals("N") || proceed.Equals("n"))
                    break;
                else
                    continue;
            }
        }

        public static void NumberDegree() // 15
        {
            while (true)
            {
                Console.Write("Enter the number: ");
                string stringNumber = Console.ReadLine();
                bool isNumber1 = Double.TryParse(stringNumber, out double number);
                Console.Write("Enter the degree: ");
                string stringDegree = Console.ReadLine();
                bool isNumber2 = Double.TryParse(stringDegree, out double degree);
                if (!isNumber1 || !isNumber2)
                {
                    Console.WriteLine("Not a numeric values. Try again...");
                    continue;
                }
                double result = 1;
                if (degree > 0)
                {
                    for (int i = 0; i < degree; i++)
                    {
                        result *= number;
                    }
                }
                else if (degree < 0)
                {
                    for (double i = degree; i < 0; i++)
                    {
                        result *= number;
                    }
                    result = 1 / result;
                }
                Console.WriteLine($"{number}^{degree} = {result}");

                Console.WriteLine("Do you want to proceed? Y/N");
                string proceed = Console.ReadLine();
                if (proceed.Equals("N") || proceed.Equals("n"))
                    break;
                else
                    continue;
            }
        }

        public static void DeletedDigit() // 16
        {
            while (true)
            {
                Console.Write("Enter the number: ");
                string stringNumber1 = Console.ReadLine();
                bool isNumber1 = Int32.TryParse(stringNumber1, out int number);
                Console.Write("Enter the digit to delete: ");
                string stringNumber2 = Console.ReadLine();
                bool isNumber2 = Int32.TryParse(stringNumber2, out int deletedDigit);

                if (!isNumber1 || !isNumber2 || number < 0)
                {
                    Console.WriteLine("Not a numeric or natural values. Try again...");
                    continue;
                }
                int temp = 0;
                int invertedNumber = 0;
                for (int i = 0; i < stringNumber1.Length; i++)
                {
                    temp = number % 10;
                    if (temp != deletedDigit)
                    {
                        invertedNumber *= 10;
                        invertedNumber += temp;
                    }
                    number /= 10;
                }
                number = invertedNumber;
                stringNumber1 = number.ToString();
                invertedNumber = 0;
                for (int i = 0; i < stringNumber1.Length; i++)
                {
                    temp = number % 10;
                    invertedNumber *= 10;
                    invertedNumber += temp;
                    number /= 10;
                }
                Console.WriteLine(invertedNumber);

                Console.WriteLine("Do you want to proceed? Y/N");
                string proceed = Console.ReadLine();
                if (proceed.Equals("N") || proceed.Equals("n"))
                    break;
                else
                    continue;
            }
        }


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

        public static void ElementsSum() // 20
        {
            Console.Write("Enter the number: ");
            string stringNumber = Console.ReadLine();
            bool isNumber = Int32.TryParse(stringNumber, out int number);

            double sum = 0;
            string output = "";
            double[] array = new double[number];
            for (int i = 0; i < number; i++)
            {
                double numerator = i+1;
                double denominator = 1;
                double temp = 2;
                for (int j = 0; j < numerator; j++) // 1 2
                {
                    denominator *= temp; // 2 
                }
                double value = numerator / denominator;
                if (numerator % 2 == 0)
                {
                    value *= -1;
                }
                array[i] = value;
                sum += value;
                if (numerator == 1)
                    output += $"{numerator}/{denominator}";
                else if (numerator % 2 == 0 && numerator > 1)
                    output += $" - {numerator}/{denominator}";
                else
                    output += $" + {numerator}/{denominator}";
            }
            Console.WriteLine($"S = {output} = {sum}");
            Console.WriteLine($"S = " + string.Join(" + ", array) + $" = {sum}");
        }

            static void Main(string[] args)
        {
            //NumberProcesses();
            //Logistics();
            //TwoNumbersAandB();
            //EvenDigits();
            //NumbersAverage();
            //Skier();
            //MultiplyOperation();
            //SquareNumber();
            //Fibonacci();
            //FibonacciAllNumbers();
            //InvertedNumber();
            //NumberDigits();
            //NumberDegree();
            //DeletedDigit();
            //MaxDigit();
            //CollatzConjecture();
            //RandomNumberGuessing();
            ElementsSum();
        }

        /*
        public static void Method()
        {
            while (true)
            {
                Console.WriteLine("");
                string stringNumber1 = Console.ReadLine();
                bool isNumber1 = Int32.TryParse(stringNumber1, out int number1);
                string stringNumber2 = Console.ReadLine();
                bool isNumber2 = Int32.TryParse(stringNumber2, out int number2);
                if (!isNumber1 || !isNumber2)
                {
                    Console.WriteLine("Not a numeric values. Try again...");
                    continue;
                }
            
            
                Console.WriteLine("Do you want to proceed? Y/N");
                string proceed = Console.ReadLine();
                if (proceed.Equals("N") || proceed.Equals("n"))
                    break;
                else
                    continue;
            }
        }
        */
    }
}