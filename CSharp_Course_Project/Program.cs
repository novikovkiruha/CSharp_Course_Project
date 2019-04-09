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

        public static void Logistics()
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

        public static void TwoNumbersAandB()
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

        public static void EvenDigits()
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

        public static void NumbersAverage()
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

        public static void Skier()
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

        public static void MultiplyOperation()
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
                        result += number2; // 0 + 
                    }
                }
                else if (number1 < 0)
                {
                    for (int i = 0; i < -number1; i++)
                    {
                        result += -number2; // 0 + 
                    }
                }
                else if (number2 < 0)
                {
                    for (int i = 0; i < -number2; i++)
                    {
                        result += -number1; // 0 + 
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

        public static void SquareNumber()
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

                int[] array = new int[number-1];
                for (int i = 1; i <= array.Length; i++)
                {
                    array[i-1] = i * i;
                    Console.WriteLine($"Square of {i} = {array[i-1]}");
                }
                Console.WriteLine(string.Join(",", array));

                Console.WriteLine("Do you want to proceed? Y/N");
                string proceed = Console.ReadLine();
                if (proceed.Equals("N") || proceed.Equals("n"))
                    break;
                else
                    continue;
            }
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
            SquareNumber();
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
        }
        */
    }
}