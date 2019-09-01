using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleRacing.SimpleRacing
{
    public class MyCar
    {
        private int[] coordinatesX;

        private int[] coordinatesY;

        public int Speed { get; }

        public int Score { get; }

        private char Symbol { get; }

        public char CarPosition { get; set; }

        public TimeSpan LifeDuration { get; set; }

        public ConsoleColor Color { get; }

        public MyCar()
        {
            this.coordinatesX = new int[] { 6, 5, 6, 7, 6, 5, 7 };
            this.coordinatesY = new int[] { 16, 17, 17, 17, 18, 19, 19 };
            this.Speed = 250;
            this.Score = 0;
            this.Symbol = 'x';
            this.LifeDuration = new TimeSpan().Duration();
            this.Color = ConsoleColor.Green;
            this.MoveRight();
        }

        public void DrawRightCar(char symbol)
        {
            for (int i = 0; i < this.coordinatesX.Length; i++)
            {
                Console.ForegroundColor = this.Color;
                Console.SetCursorPosition(this.coordinatesX[i], this.coordinatesY[i]);

                Console.WriteLine(symbol);
            }
        }

        public void DrawLeftCar(char symbol)
        {
            for (int i = 0; i < this.coordinatesX.Length; i++)
            {
                Console.ForegroundColor = this.Color;
                Console.SetCursorPosition(this.coordinatesX[i] - 3, this.coordinatesY[i]);

                Console.WriteLine(symbol);
            }
        }

        public void MoveLeft()
        {
            lock (GameLogic.locker)
            {
                this.DrawRightCar(' ');

                this.DrawLeftCar(this.Symbol);

                this.CarPosition = 'L';
            }
        }

        public void MoveRight()
        {
            lock (GameLogic.locker)
            {
                this.DrawLeftCar(' ');

                this.DrawRightCar(this.Symbol);

                this.CarPosition = 'R';
            }
        }

        public void IncreaseSpeed()
        {
            Console.WriteLine(this.LifeDuration);
        }
    }
}
