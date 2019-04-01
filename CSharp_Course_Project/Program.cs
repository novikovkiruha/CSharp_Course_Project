using System;

namespace CSharp_Course_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            //squareCircle();
            //Average();
            //Volume();
            //Area();

            HT1_IntVariable();
        }

        public static void squareCircle()
        {
            const double pi = Math.PI;
            Console.Write("Enter a radius of a circle: ");
            string radius = Console.ReadLine();
            double r = Convert.ToInt32(radius);
            double squareCircle = (r * r) * pi;
            Console.WriteLine(squareCircle);
        }

        public static double squareCircle(int r)
        {
            const double pi = Math.PI;
            double square = (r * r) * pi;
            return square;
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

        //Задание №1. Переменные
        public static void HT1_IntVariable()
        {
            int x1 = 10;
            Console.WriteLine(x1);
        }


    }
}