using practice_07._20._2019_multithreading.Task1_FallingSymbols;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace practice_07._20._2019_multithreading
{
    class Program
    {
        static object locker = new object();

        static int Generate(int a, int b) // Метод генерирования рандомных чисел
        {
            Random rand = new Random((int)DateTime.Now.Ticks & 0x0000FFFF);
            return rand.Next(a, b);
        }

        static void Matrix(object numberColumn) // метод вывода столбцов с символами, в качестве параметра принимает позицию строки курсора
        {
            while (true)
            {
                int lenghtColumn = 0;
                int position = 0; // Позиция столбца курсора
                const int maxLenght = 40; // максимальная длинна столбца
                Random rand = new Random();
                int count = Generate(25, 39); //длинна столбца 
                Thread.Sleep(555);
                for (int i = 0; i != maxLenght + count; i++)
                {
                    lock (locker)
                    {
                        Console.ForegroundColor = ConsoleColor.Black; //Задаём чёрный цвет тексту
                        for (int j = 0; j <= position; j++) // В цикле закрашиваем символы черным квадратом
                        {
                            Console.SetCursorPosition((int)numberColumn, j); // Устанавливаем позицию курсора
                            Console.WriteLine("█"); // Так как мы поменяли цвет текста в консоли на чёрный, то квадрат не будет красным
                        }
                        if (lenghtColumn < count && position != 40)
                        {
                            ++lenghtColumn;
                        }
                        else if (position == maxLenght)
                        {
                            --lenghtColumn;
                        }
                        if (lenghtColumn >= 3)
                        {
                            for (int k = position - (lenghtColumn - 1); k <= position - 2; k++)
                            {
                                Console.SetCursorPosition((int)numberColumn, k);
                                Console.ForegroundColor = ConsoleColor.DarkGreen;
                                Console.WriteLine((char)rand.Next('A', 'z'));
                            }
                        }
                        if (lenghtColumn >= 2)
                        {
                            Console.SetCursorPosition((int)numberColumn, position - 1);
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine((char)rand.Next('A', 'z'));
                        }
                        if (lenghtColumn >= 1)
                        {
                            Console.SetCursorPosition((int)numberColumn, position);
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine((char)rand.Next('A', 'z'));
                            if (position != maxLenght) position++;
                        }
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            //SignsShower signsShower = new SignsShower();

            ////готовим консоль
            //Console.Clear();
            //Console.CursorVisible = false;

            ////в бесконечном цикле с вычисляемой задержкой отображаем
            //while (true)
            //{
            //    //отображаем символы
            //    signsShower.SignShow();

            //    //задержка
            //    Thread.Sleep(100);
            //}

            Console.SetWindowSize(80, 42);

            Matrix2 instance;

            //for (int i = 0; i < 26; i++)
            //{
            //    instance = new Matrix2(i * 3, true);
            //    new Thread(instance.Move).Start();
            //}

            new FallingSymbols().Execute();
            //new FallingSymbols().Matrix();

            //Console.SetWindowSize(100, 42);
            //Thread t;
            //for (int i = 0; i < 100; i++)
            //{
            //    t = new Thread(Matrix);
            //    t.Start(i);
            //}
            //Console.ReadKey();
        }
    }
}
