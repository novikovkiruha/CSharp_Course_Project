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
            //HT6_2DigitNumberOperations();
            //HT7_IntAndLongConversion();
            //HT8_LongAndByteConversion();
            HT9_TwoVariables();
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

        //Задание №7. Преобразования базовых типов данных
        public static void HT7_IntAndLongConversion()
        {
            int x1 = 10;
            int x2 = 260;
            long sum = x1 + x2;
            Console.WriteLine(sum);
        }

        //Задание №8. Преобразования базовых типов данных
        public static void HT8_LongAndByteConversion()
        {
            long x1 = 15;
            long x2 = 16;
            byte multiply = (byte)(x1 * x2);
            Console.WriteLine(multiply);
        }

        //Задание №9. 
        //Даны две целые переменные a, b.Составить фрагмент программы, после исполнения которого значения переменных поменялись бы местами.
        //Решить двумя способами.

        public static void HT9_TwoVariables()
        {
            //1st option
            int a = 2;
            int b = 3;
            
            int temp = a;
            a = b;
            b = temp;
            Console.WriteLine($"a: {a}, b: {b}");

            //2nd option
            int x = 2;
            int y = 3;

            x = y + x; // 2 + 3 = 6
            y = x - y; // 6 - 3 = 2
            x = x - y; // 6 - 2 = 3
            Console.WriteLine($"x: {x}, y: {y}");
        }
    }
}