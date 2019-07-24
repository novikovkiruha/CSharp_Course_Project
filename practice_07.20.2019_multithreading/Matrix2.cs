﻿using System;
using System.Threading;

namespace practice_07._20._2019_multithreading
{
    public class Matrix2
    {
        public void Execute()
        {
            Console.SetWindowSize(80, 42);

            Matrix2 instance;

            for (int i = 0; i < 26; i++)
            {
                instance = new Matrix2(i * 3, true);
                new Thread(instance.Move).Start();
            }
        }

        static object locker = new object();

        Random rand;

        const string litters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";

        public int Colunm { get; set; }

        public bool NeedSecond { get; set; }

        public Matrix2(int col, bool needSecond)
        {
            Colunm = col;
            rand = new Random((int)DateTime.Now.Ticks);
            NeedSecond = needSecond;
        }

        private char GetChar()
        {
            return litters.ToCharArray()[rand.Next(0, 35)];
        }

        public void Move()
        {
            int lenght;
            int count;

            while (true)
            {
                count = rand.Next(3, 12);
                lenght = 0;
                Thread.Sleep(rand.Next(20, 5000));
                for (int i = 0; i < 40; i++)
                {
                    lock (locker)
                    {
                        //  Console.CursorTop = 0;

                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.CursorTop = i - lenght;
                        for (int j = i - lenght - 1; j < i; j++)
                        {
                            Console.CursorLeft = Colunm;
                            Console.WriteLine("в–€");
                        }

                        if (lenght < count)
                            lenght++;
                        else
                            if (lenght == count)
                            count = 0;
                        if (NeedSecond && i < 20 && i > lenght + 2 && (rand.Next(1, 5) == 3))
                        {
                            new Thread((new Matrix2(Colunm, false)).Move).Start();
                            NeedSecond = false;
                        }

                        if (39 - i < lenght)
                            lenght--;
                        Console.CursorTop = i - lenght + 1;
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        for (int j = 0; j < lenght - 2; j++)
                        {
                            Console.CursorLeft = Colunm;
                            Console.WriteLine(GetChar());
                        }
                        if (lenght >= 2)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.CursorLeft = Colunm;
                            Console.WriteLine(GetChar());
                        }
                        if (lenght >= 1)
                        {
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.CursorLeft = Colunm;
                            Console.WriteLine(GetChar());
                        }

                        Thread.Sleep(10);
                    }
                }
            }
        }
    }
}
