using System;
using System.Threading;

namespace practice_07._20._2019_multithreading.Task1_FallingSymbols
{
    public class FallingSymbols
    {
        static readonly object locker = new object();

        public Random random = new Random();

        private int consoleWidth = 100;

        private int consoleHeight = 50;

        public FallingSymbols()
        {
        }

        public FallingSymbols(int consoleWidth, int consoleHeight)
        {
            this.consoleWidth = consoleWidth;
            this.consoleHeight = consoleHeight;
        }

        public void Execute()
        {
            while (true)
            {
                var thread1 = new Thread(new ThreadStart(PrintSymbols));
                var thread2 = new Thread(new ThreadStart(PrintSymbols));
                thread1.Start();
                thread2.Start();
                new FallingSymbols().PrintSymbols();
            }
            new FallingSymbols().PrintSymbols();
        }

        public void PrintSymbols()
        {
            lock (locker)
            {
                Console.SetWindowSize(this.consoleWidth, this.consoleHeight);

                Console.CursorVisible = false;
                var symbolLength = this.random.Next(3, 10);
                var leftCursorPosition = this.random.Next(0, this.consoleWidth);
                var topCursorPosition = this.random.Next(0, this.consoleHeight);

                var start = 0;
                var temp = 0;

                for (int i = 0; i < this.consoleHeight - 1; i++)
                {
                    if (i == temp)
                        Console.ForegroundColor = ConsoleColor.White;
                    else if (i == temp + 1)
                        Console.ForegroundColor = ConsoleColor.Green;
                    else
                        Console.ForegroundColor = ConsoleColor.DarkGreen;

                    temp++;

                    Console.SetCursorPosition(leftCursorPosition, i);

                    var charRandom = this.random.Next(48, 126);
                    Console.WriteLine($"{Convert.ToChar(charRandom)}");

                    if (i > symbolLength)
                    {
                        Console.SetCursorPosition(leftCursorPosition, start);
                        Console.WriteLine(" ");
                        start++;
                    }

                    var end = consoleHeight - 2 - symbolLength;
                    if (i == this.consoleHeight - 2)
                    {
                        for (int j = 0; j < symbolLength + 1; j++)
                        {
                            Console.SetCursorPosition(leftCursorPosition, end);
                            Console.WriteLine(" ");
                            end++;

                            Thread.Sleep(100);
                        }
                    }

                    Console.SetCursorPosition(0, i + 1);

                    Thread.Sleep(100);
                }
            }
        }

        public void SetSymbolColor(int firstValue, int secondValue)
        {
            if (firstValue == secondValue)
                Console.ForegroundColor = ConsoleColor.White;
            else if (firstValue == secondValue + 1)
                Console.ForegroundColor = ConsoleColor.Green;
            else
                Console.ForegroundColor = ConsoleColor.DarkGreen;
        }
    }
}
