using SimpleRacing.SimpleRacing;
using System;
using System.Threading;

namespace SimpleRacing
{
    public class Border
    {
        private char Symbol { get; }

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
                    Thread.Sleep(20);

                    this.DrawBorder('!', i, fieldWidth);

                    if (i % 2 == 0)
                    {
                        this.DrawBorder(' ', i, fieldWidth);
                    }
                }

                for (int i = 0; i < fieldHeight; i++)
                {
                    Thread.Sleep(20);

                    this.DrawBorder('!', i, fieldWidth);

                    if (i % 2 != 0 && i != 0)
                    {
                        this.DrawBorder(' ', i, fieldWidth);
                    }
                }

                if (MyCar.IsCrash)
                {
                    Thread.CurrentThread.Abort();
                }
            }
        }

        public void DrawBorder(char symbol, int positionX, int positionY)
        {
            lock (GameLogic.locker)
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
