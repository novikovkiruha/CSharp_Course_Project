using System;

namespace CSharp_Course_Project
{
    class Program
    {
        public static void MaxDigit()
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

        static void Main(string[] args)
        {
            MaxDigit();
        }
    }
}