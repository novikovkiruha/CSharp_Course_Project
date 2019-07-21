using System;
using System.Threading;

namespace practice_07._20._2019_multithreading.Task1_FallingSymbols
{
    public class FallingSymbols
    {
        static readonly object locker = new object();

        public Random random = new Random();

        private readonly int consoleWidth = 100;

        private readonly int consoleHeight = 50;

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
                var thread = new Thread(new ThreadStart(PrintSymbols));
                thread.Start();
                new FallingSymbols().PrintSymbols();
            }
            //new FallingSymbols().PrintSymbols();
        }

        public void PrintSymbols()
        {
            //lock (locker)
            //{
            Console.SetWindowSize(this.consoleWidth, this.consoleHeight);
            var symbolLength = this.random.Next(3, 10);
            var leftCursorPosition = this.random.Next(0, this.consoleWidth);
            var topCursorPosition = this.random.Next(0, this.consoleHeight);
            //Console.SetCursorPosition(0, 0);

            for (int i = 0; i < symbolLength; i++)
            {
                leftCursorPosition = this.random.Next(0, this.consoleWidth);
                topCursorPosition = this.random.Next(0, this.consoleHeight);
                //Console.SetCursorPosition(this.random.Next(0, 70), i);
                for (int j = 0; j < i + 1; j++)
                {
                    Console.SetCursorPosition(leftCursorPosition, topCursorPosition);

                    Console.SetCursorPosition(leftCursorPosition, j);
                    this.SetSymbolColor(i, j);
                    var charRandom = this.random.Next(48, 126);
                    topCursorPosition++;
                    Console.WriteLine($"{Convert.ToChar(charRandom)}");

                    Thread.Sleep(100);
                    Console.SetCursorPosition(leftCursorPosition, this.random.Next(0, 40));
                }
            }

            //while (true)
            //{
            //    leftCursorPosition = this.random.Next(0, this.consoleWidth);
            //    topCursorPosition = this.random.Next(0, this.consoleHeight);
            //    Console.SetCursorPosition(leftCursorPosition, topCursorPosition - symbolLength);
            //    symbolLength = this.random.Next(3, 10);
            //    for (int i = 0; i < symbolLength; i++)
            //    {
            //        //Console.SetCursorPosition(leftCursorPosition, topCursorPosition);
            //        Console.ForegroundColor = ConsoleColor.Green;
            //        //this.SetSymbolColor(i, j);
            //        var charRandom = this.random.Next(48, 126);
            //        //topCursorPosition++;
            //        Console.WriteLine($"{Convert.ToChar(charRandom)}");

            //        Thread.Sleep(400);
            //    }
            //}
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
