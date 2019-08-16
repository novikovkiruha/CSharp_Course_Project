using System;
using System.Threading;

namespace SimpleRacing
{
    public class Border
    {
        private object locker;

        public char Symbol { get; }

        public ConsoleColor Color { get; }

        public Border()
        {
            this.Symbol = '!';
            this.Color = ConsoleColor.White;
        }

        public void DrawBorder(int fieldHeight, int fieldWidth)
        {
            Console.ForegroundColor = this.Color;

            for (int i = 0; i < fieldHeight; i++)
            {
                Console.SetCursorPosition(0, i);
                Console.WriteLine(this.Symbol);
                Console.SetCursorPosition(fieldWidth, i);
                Console.WriteLine(this.Symbol);
            }
        }
    }
}
