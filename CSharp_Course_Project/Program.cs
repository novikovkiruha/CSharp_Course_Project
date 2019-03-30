using System;

namespace CSharp_Course_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            Average();
            Volume();
            Area();
        }

        static int Sum(int x, int y)
        {
            return x + y;
        }

        public static void Average()
        {
            Console.WriteLine("Enter 3 numbers:");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            double average = (double)(a + b + c) / 3;
            Console.WriteLine(average);
        }

        public static void Volume()
        {
            const double PI = Math.PI;
            Console.Write("Enter a radius: ");
            double radius = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter a height: ");
            double height = Convert.ToDouble(Console.ReadLine());
            double volume = PI * radius * 2 * height;
            Console.WriteLine(volume);
        }

        public static void Area()
        {
            const double PI = Math.PI;
            Console.Write("Enter a radius: ");
            double radius = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter a height: ");
            double height = Convert.ToDouble(Console.ReadLine());
            double area = 2 * PI * radius * (radius + height);
            Console.WriteLine(area);
        }
    }
}