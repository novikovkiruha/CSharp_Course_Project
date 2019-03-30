using System;

namespace CSharp_Course_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            //squareCircle();
            //Console.WriteLine(squareCircle2(4));

            //task1();
            //task2();
            //task3();
        }

        public static void squareCircle()
        {
            const double PI = Math.PI;
            Console.Write("Enter a radius of a circle: ");
            string radius = Console.ReadLine();
            double r = Convert.ToInt32(radius);
            double squareCircle = (r*r) * PI;
            Console.WriteLine(squareCircle);
        }

        public static double squareCircle2(int r)
        {
            const double pi = Math.PI;
            double square = (r * r) * pi;
            return square;
        }

        public static void task1()
        {
            int uberflu = 1;
            int _identifier = 1;
            int u006identifier = 1;
            int myVar = 1;
            int myVariable = 1;
        }

        public static void task2()
        {
            double pi = 3.141592653;
            double e = 2.7182818284590452;
            Console.WriteLine(pi);
            Console.WriteLine(e);
        }

        public static void task3()
        {
            string string1 = "\nмоя строка 1";
            string string2 = "\tмоя строка 2";
            string string3 = "\aмоя строка 3";
            Console.WriteLine(string1);
            Console.WriteLine(string2);
            Console.WriteLine(string3);
        }
    }
}