using System;

namespace CSharp_Course_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            short num1 = 10;
            short num2 = 15;

            Console.WriteLine($"{num1} + {num2} = {Program.Sum(num1, num2)}");
        }

        static int Sum(int x, int y)
        {
            return x + y;
        }
    }
}