using System;
using System.Threading;

namespace practice_07._20._2019_multithreading.FallingSymbolsMultithreading
{
    public class FallingSymbolsMultithreading
    {
        static readonly object locker = new object();

        public Random random = new Random();

        private readonly int consoleWidth;

        private readonly int consoleHeight;

        public FallingSymbolsMultithreading()
        {
            this.consoleWidth = 100;
            this.consoleHeight = 50;
            Console.SetWindowSize(this.consoleWidth, this.consoleHeight);
            Console.CursorVisible = false;
        }

        public void Execute()
        {
            //while (true)
            //{
            //    Thread.Sleep(new Random().Next(10, 1000));
            //    new Thread(new ThreadStart(this.PrintSymbols)).Start();
            //}

            this.PrintSymbols();
        }

        public void PrintSymbols()
        {
            var symbolSpeed = 150;

            while (true)
            {
                var symbolLength = this.random.Next(3, this.consoleHeight / 3);
                var leftCursorPosition = this.random.Next(0, this.consoleWidth - 1);

                var start = 0;

                for (int i = 0; i < this.consoleHeight - 1; i++)
                {
                    Thread.Sleep(symbolSpeed);

                    Console.ForegroundColor = ConsoleColor.White;

                    lock (locker)
                    {
                        Console.SetCursorPosition(leftCursorPosition, i);

                        Console.WriteLine($"{ConvertToChar()}");

                        var temp = i;
                        if (temp > symbolLength)
                        {
                            for (int k = temp - symbolLength; k <= i; k++)
                            {
                                this.SetSymbolColor(i, k);

                                Console.SetCursorPosition(leftCursorPosition, k);

                                Console.WriteLine($"{ConvertToChar()}");

                                temp++;
                            }
                        }

                        if (i > symbolLength)
                        {
                            //for (int j = 0; j < i - symbolLength; j++)
                            //{
                            //    this.PrintBlankSymbol(leftCursorPosition, j);
                            //}

                            this.PrintBlankSymbol(leftCursorPosition, start);
                            start++;
                        }
                    }

                    var end = this.consoleHeight - 2 - symbolLength;

                    if (i == this.consoleHeight - 2)
                    {
                        for (int j = 0; j < symbolLength + 1; j++)
                        {
                            lock (locker)
                            {
                                this.PrintBlankSymbol(leftCursorPosition, end);
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
        }

        public char ConvertToChar()
        {
            var pickedRandom = this.random.Next(0, 3);

            var symbol = ' ';

            switch (pickedRandom)
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

        public void SetSymbolColor(int firstValue, int secondValue)
        {
            if (firstValue == secondValue + 1)
                Console.ForegroundColor = ConsoleColor.Green;
            else
                Console.ForegroundColor = ConsoleColor.DarkGreen;
        }
    }
}
