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

            //HT1_IntVariable();
            //HT2_StringVariables();
            //HT3_VarVariable();
            //HT4_PerimetrOperations();
            //HT5_AreasOperations();
            HT6_2DigitNumberOperations();
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

        //Задание №2. Переменные
        public static void HT2_StringVariables()
        {
            Console.Write("Enter your name: ");
            string str1 = Console.ReadLine();
            string str2 = "Hi, " + str1;
            Console.WriteLine(str2);
        }

        //Задание №3. Переменные
        public static void HT3_VarVariable()
        {
            var v1 = 'v';
            //v1 = "variable"; //can't change variable type
            //v1 = 10; //can't change variable type
            v1 = 'c';
            Console.WriteLine(v1);
        }

        //Задание №4. Операции
        public static void HT4_PerimetrOperations()
        {
            Console.WriteLine("Введите длину стороны квадрата:");
            int x = Int32.Parse(Console.ReadLine());
            int p = 4 * x;
            Console.WriteLine(p);
        }

        //Задание №5. Операции
        public static void HT5_AreasOperations()
        {
            const double PI = Math.PI;
            Console.Write("Enter the larger circle radius: ");
            int r1 = Int32.Parse(Console.ReadLine());
            Console.Write("Enter the smaller circle radius: ");
            int r2 = Int32.Parse(Console.ReadLine());

            double s1 = PI * r1 * r1;
            double s2 = PI * r2 * r2;
            double s3 = s1 - s2;

            Console.WriteLine($"S1 = {s1}\nS2 = {s2}\nS3 = {s3}");
        }

        //Задание №6. Операции
        //Дано двузначное число.Выведите на консоль вначале его левую цифру(десятки), а затем – его правую цифру(единицы).
        //Для нахождения десятков использовать операцию деления нацело, для нахождения единиц – операцию взятия остатка от деления.
        public static void HT6_2DigitNumberOperations()
        {
            Console.Write("Enter the 2-digit number: ");
            string n = Console.ReadLine();
            if (n.Length == 2)
            {
                int number = Int32.Parse(n);
                int right = number % 10;
                int left = number /= 10;
                Console.WriteLine($"Left digit: {left}\nRight digit: {right}");
            }
            else
            {
                Console.WriteLine("Not a 2-digit number. Try again...");
            }
        }
    }
}