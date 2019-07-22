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
            //while (true)
            //{
            //    var thread1 = new Thread(new ThreadStart(PrintSymbols));
            //    var thread2 = new Thread(new ThreadStart(PrintSymbols));
            //    thread1.Start();
            //    thread2.Start();
            //    new FallingSymbols().PrintSymbols();
            //}
            new FallingSymbols().PrintSymbols();
        }

        public void PrintSymbols()
        {
            //lock (locker)
            //{
            Console.SetWindowSize(this.consoleWidth, this.consoleHeight);
            var symbolLength = this.random.Next(3, 10);
            var leftCursorPosition = this.random.Next(0, this.consoleWidth);
            var topCursorPosition = this.random.Next(0, this.consoleHeight);

            var i = 0;

            for (i = 0; i < this.consoleHeight; i++)
            {
                //symbolLength = this.random.Next(3, this.consoleHeight);
                //leftCursorPosition = this.random.Next(0, this.consoleWidth);

                for (int j = 0; j < i + 1; j++)
                {
                    Console.SetCursorPosition(leftCursorPosition, j);
                    this.SetSymbolColor(i, j);
                    var charRandom = this.random.Next(48, 126);
                    Console.WriteLine($"{Convert.ToChar(charRandom)}");
                    Thread.Sleep(5);
                }
            }

            //for (int i = 0; i < this.consoleHeight; i++)
            //{
            //    symbolLength = this.random.Next(3, 15);
            //    leftCursorPosition = this.random.Next(0, this.consoleWidth);
            //    for (int j = 0; j < symbolLength; j++)
            //    {
            //        for (int k = 0; k < j + 1; k++)
            //        {
            //            this.SetSymbolColor(j, k);
            //            if (j == k)
            //                Console.ForegroundColor = ConsoleColor.White;
            //            else if (j == k + 1 || j == k + 2 || j == k + 3)
            //                Console.ForegroundColor = ConsoleColor.Green;
            //            else if (j < symbolLength)
            //                Console.ForegroundColor = ConsoleColor.DarkGreen;
            //            else
            //                Console.ForegroundColor = ConsoleColor.Black;

            //            Console.SetCursorPosition(leftCursorPosition, k);
            //            var charRandom = this.random.Next(48, 126);
            //            Console.WriteLine($"{Convert.ToChar(charRandom)}");
            //            Thread.Sleep(100);
            //        }
            //    }
            //}

            //topCursorPosition = 0;
            //while (true)
            //{
            //    symbolLength = this.random.Next(3, 15);
            //    leftCursorPosition = this.random.Next(0, this.consoleWidth);

            //    for (int i = 0; i < symbolLength; i++)
            //    {
            //        Console.SetCursorPosition(leftCursorPosition, topCursorPosition);
            //        var charRandom = this.random.Next(48, 126);
            //        Console.WriteLine($"{Convert.ToChar(charRandom)}");
            //        topCursorPosition++;

            //        Thread.Sleep(100);
            //    }
            //}
        }

        public void SetSymbolColor(int firstValue, int secondValue)
        {
            if (firstValue == secondValue)
                Console.ForegroundColor = ConsoleColor.White;
            else if (firstValue == secondValue + 1 || firstValue == secondValue + 2 || firstValue == secondValue + 3)
                Console.ForegroundColor = ConsoleColor.Green;
            else
                Console.ForegroundColor = ConsoleColor.DarkGreen;
        }
    }
}
