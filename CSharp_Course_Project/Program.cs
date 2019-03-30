using System;

namespace CSharp_Course_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            squareCircle();
            //Console.WriteLine(squareCircle2(4)); 
        }

        public static void squareCircle()
        {
            const double pi = Math.PI;
            Console.Write("Enter a radius of a circle: ");
            string radius = Console.ReadLine();
            double r = Convert.ToInt32(radius);
            double squareCircle = (r*r) * pi;
            Console.WriteLine(squareCircle);
        }

        public static double squareCircle2(int r)
        {
            const double pi = Math.PI;
            double square = (r * r) * pi;
            return square;
        }
    }
}