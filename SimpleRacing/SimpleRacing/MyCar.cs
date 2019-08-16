using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleRacing.SimpleRacing
{
    public class MyCar
    {
        static private object locker;

        public char Symbol { get; }

        public int[] coordinatesX;

        public int[] coordinatesY;

        public ConsoleColor Color { get; }

        public MyCar()
        {
            this.coordinatesX = new int[] { 6, 5, 6, 7, 6, 5, 7 };
            this.coordinatesY = new int[] { 16, 17, 17, 17, 18, 19, 19 };
            this.Symbol = '^';
            this.Color = ConsoleColor.Green;
        }

        public void DrawStartCar()
        {
            for (int i = 0; i < 7; i++)
            {
                Console.ForegroundColor = this.Color;
                Console.SetCursorPosition(this.coordinatesX[i], this.coordinatesY[i]);

                Console.WriteLine(this.Symbol);
            }
        }

        public void DrawRightCar(char symbol)
        {
            for (int i = 0; i < 7; i++)
            {
                Console.ForegroundColor = this.Color;
                Console.SetCursorPosition(this.coordinatesX[i], this.coordinatesY[i]);

                Console.WriteLine(symbol);
            }
        }

        public void DrawLeftCar(char symbol)
        {
            for (int i = 0; i < 7; i++)
            {
                Console.ForegroundColor = this.Color;
                Console.SetCursorPosition(this.coordinatesX[i] - 3, this.coordinatesY[i]);

                Console.WriteLine(symbol);
            }
        }

        public void MoveLeft()
        {
            this.DrawRightCar(' ');

            this.DrawLeftCar(this.Symbol);
        }

        public void MoveRight()
        {
            this.DrawLeftCar(' ');

            this.DrawRightCar(this.Symbol);
        }
    }
}
