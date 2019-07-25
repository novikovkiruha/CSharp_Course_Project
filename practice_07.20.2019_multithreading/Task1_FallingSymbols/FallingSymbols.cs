using System;
using System.Threading;

namespace practice_07._20._2019_multithreading.Task1_FallingSymbols
{
    public class FallingSymbols
    {
        static readonly object locker = new object();

        public Random random = new Random();

        private readonly int consoleWidth;

        private readonly int consoleHeight;

        public FallingSymbols()
        {
            this.consoleWidth = 100;
            this.consoleHeight = 50;
            Console.SetWindowSize(this.consoleWidth, this.consoleHeight);
            Console.CursorVisible = false;
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
                for (int i = 0; i < this.consoleWidth; i++)
                {
                    Thread.Sleep(new Random().Next(10, 1000));
                    new Thread(new ThreadStart(this.PrintSymbols)).Start();
                }
            }
        }

        public void PrintSymbols()
        {
            var symbolLength = this.random.Next(3, this.consoleHeight / 2);
            var leftCursorPosition = this.random.Next(0, this.consoleWidth - 1);
            var symbolSpeed = this.random.Next(30, 500);

            var start = 0;

            for (int i = 0; i < this.consoleHeight - 1; i++)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;

                Thread.Sleep(symbolSpeed);

                lock (locker)
                {
                    Console.SetCursorPosition(leftCursorPosition, i);

                    Console.WriteLine($"{ConvertToChar()}");

                    if (i > symbolLength)
                    {
                        this.PrintSpaceSymbol(leftCursorPosition, start);
                        start++;
                    }
                }

                var end = consoleHeight - 2 - symbolLength;

                if (i == this.consoleHeight - 2)
                {
                    for (int j = 0; j < symbolLength + 1; j++)
                    {
                        lock (locker)
                        {
                            this.PrintSpaceSymbol(leftCursorPosition, end);
                            end++;
                        }

                        Thread.Sleep(symbolSpeed);
                    }
                }

                lock (locker)
                {
                    Console.SetCursorPosition(0, i + 1);
                }
            }
        }

        public char ConvertToChar()
        {
            return Convert.ToChar(this.random.Next(48, 126));
        }

        public void PrintSpaceSymbol(int left, int top)
        {
            Console.SetCursorPosition(left, top);
            Console.WriteLine(" ");
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
