using System;
using System.Threading;

namespace practice_07._20._2019_multithreading.Task1and2_Matrix
{
    public class FallingSymbols
    {
        static readonly object locker = new object();

        private Random random;

        private readonly int consoleWidth;

        private readonly int consoleHeight;

        public FallingSymbols()
        {
            this.random = new Random();
            this.consoleWidth = 120;
            this.consoleHeight = 50;
            Console.SetWindowSize(this.consoleWidth, this.consoleHeight);
            Console.CursorVisible = false;
        }

        public void ExecuteMatrix()
        {
            while (true)
            {
                Thread.Sleep(new Random().Next(20, 1000));
                new Thread(new ThreadStart(this.PrintSymbols)).Start();
            }
        }

        public void PrintSymbols()
        {
            while (true)
            {
                var symbolLength = this.random.Next(3, this.consoleHeight / 3);
                var symbolSpeed = this.random.Next(50, 300);
                var leftCursorPosition = this.random.Next(0, this.consoleWidth - 1);
                var emptySpace = this.consoleHeight - symbolLength;

                for (int i = 0; i < this.consoleHeight; i++)
                {
                    Thread.Sleep(symbolSpeed);

                    lock (locker)
                    {
                        Console.SetCursorPosition(leftCursorPosition, i);

                        if (i > 0)
                        {
                            this.PrintBlankSymbol(leftCursorPosition, i - 1);
                        }
                    }

                    int whiteColorPosition = i;
                    int greenColorPosition = i;
                    int darkGreenColorPosition = i;

                    if (i < emptySpace + 2)
                    {
                        for (int j = 0; j < symbolLength; j++)
                        {
                            if (i == 0)
                                Thread.Sleep(symbolSpeed);

                            lock (locker)
                            {
                                if (j > 1)
                                {
                                    this.SetColor(leftCursorPosition, darkGreenColorPosition, ConsoleColor.DarkGreen);
                                    darkGreenColorPosition++;
                                }

                                if (i < emptySpace)
                                {
                                    if (j > 0)
                                    {
                                        this.SetColor(leftCursorPosition, greenColorPosition, ConsoleColor.Green);
                                        greenColorPosition++;
                                    }

                                    this.SetColor(leftCursorPosition, whiteColorPosition, ConsoleColor.White);
                                    whiteColorPosition++;
                                }
                            }
                        }
                    }
                }
            }
        }

        public char ConvertToChar()
        {
            var randomSelection = this.random.Next(0, 3);

            var symbol = ' ';

            switch (randomSelection)
            {
                case 0:
                    symbol = Convert.ToChar(this.random.Next(48, 57));
                    break;
                case 1:
                    symbol = Convert.ToChar(this.random.Next(63, 90));
                    break;
                case 2:
                    symbol = Convert.ToChar(this.random.Next(97, 122));
                    break;
                default:
                    symbol = '$';
                    break;
            }

            return symbol;
        }

        public void PrintBlankSymbol(int left, int top)
        {
            Console.SetCursorPosition(left, top);
            Console.WriteLine(" ");
        }

        public void SetColor(int leftPosition, int topPosition, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.SetCursorPosition(leftPosition, topPosition);
            Console.WriteLine($"{ConvertToChar()}");
        }
    }
}
