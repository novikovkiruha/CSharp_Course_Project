using System;

namespace CSharp_Course_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            int i1 = 435;
            int i2 = 24500;
            decimal dec = 7.98845m;

            Console.WriteLine((short)i1);
            Console.WriteLine((short)i2);

            Console.WriteLine((int)dec);
        }

        static int Sum(int x, int y)
        {
            return x + y;
        }
    }
}