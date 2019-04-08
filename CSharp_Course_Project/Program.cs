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

        //Дано два числа A и B(A<B) выведите сумму всех чисел расположенных между данными числами на экран.
        //Дано два числа A и B (A<B) выведите все нечетные значения, расположенные между данными числами. 
        public static void TwoNumbersAandB()
        {
            while (true)
            {
                Console.WriteLine("Enter 2 numbers:");
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
                Console.WriteLine("Do you want to proceed? Y/N");
                string proceed = Console.ReadLine();
                if (proceed.Equals("Y") || proceed.Equals("y"))
                    continue;
                else
                    break;
            }
        }

        static void Main(string[] args)
        {
            //NumberProcesses();
            //Logistics();
            TwoNumbersAandB();
        }
    }
}