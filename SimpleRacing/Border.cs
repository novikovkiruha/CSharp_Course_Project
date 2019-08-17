using System;
using System.Threading;

namespace SimpleRacing
{
    public class Border
    {
        private object locker = new object();

        public char Symbol { get; }

        public ConsoleColor Color { get; }

        public Border()
        {
            this.Symbol = '!';
            this.Color = ConsoleColor.White;
        }

        public void MoveBorder(int fieldHeight, int fieldWidth)
        {
            while (true)
            {
                for (int i = 0; i < fieldHeight; i++)
                {
                    lock (locker)
                    {
                        this.DrawBorder('!', i, fieldWidth);
                    }
                }

                for (int i = 0; i < fieldHeight; i++)
                {
                    Thread.Sleep(100);

                    lock (locker)
                    {
                        if (i % 4 == 0)
                        {
                            this.DrawBorder(' ', i, fieldWidth);
                        }
                    }
                }
            }
        }

        public void DrawBorder(char symbol, int positionX, int positionY)
        {
            lock (locker)
            {
                Console.ForegroundColor = this.Color;

                Console.SetCursorPosition(0, positionX);
                Console.WriteLine(symbol);
                Console.SetCursorPosition(positionY, positionX);
                Console.WriteLine(symbol);
            }
        }
    }
}
