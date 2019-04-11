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

        /*Возьмем любое натуральное число. Если оно четное - разделим его пополам, если нечетное - умножим на 3, 
         * прибавим 1 и разделим пополам. Повторим эти действия с вновь полученным числом.
         * Гипотеза гласит, что независимо от выбора первого числа рано или поздно мы получим 1.*/
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

        static void Main(string[] args)
        {
            //MaxDigit();
            CollatzConjecture();
        }
    }
}