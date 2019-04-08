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

        //Имеется N клиентов, которым компания производитель должна доставить товар.
        //Сколько существует возможных маршрутов доставки товара, с учетом того, что товар будет доставлять одна машина?  
        //Напишите программу, которая будет рассчитывать, и выводить на экран количество возможных вариантов доставки товара.
        //Для решения задачи, используйте факториал N!, рассчитываемый с помощью цикла do-while.
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

        static void Main(string[] args)
        {
            //NumberProcesses();
            Logistics();
        }
    }
}