using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SimpleRacing.SimpleRacing
{
    public class MyCar
    {
        public event EventHandler<CrashStatusEventArgs> CrashStatus;

        private readonly int[] coordinatesX;

        private readonly int[] coordinatesY;

        private char Symbol { get; }

        public ConsoleColor Color { get; }

        static public char MyCarPosition { get; set; }

        static public bool IsCrash { get; set; }

        public MyCar()
        {
            this.coordinatesX = new int[] { 6, 5, 6, 7, 6, 5, 7 };
            this.coordinatesY = new int[] { 16, 17, 17, 17, 18, 19, 19 };
            this.Symbol = 'o';
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

                if (MyCar.IsCrash)
                {
                    Thread.CurrentThread.Abort();
                }
            }
        }

        public void DrawLeftCar(char symbol)
        {
            for (int i = 0; i < this.coordinatesX.Length; i++)
            {
                Console.ForegroundColor = this.Color;
                Console.SetCursorPosition(this.coordinatesX[i] - 3, this.coordinatesY[i]);

                Console.WriteLine(symbol);

                if (MyCar.IsCrash)
                {
                    Thread.CurrentThread.Abort();
                }
            }
        }

        public void MoveLeft()
        {
            lock (GameLogic.locker)
            {
                this.DrawRightCar(' ');

                this.DrawLeftCar(this.Symbol);

                MyCar.MyCarPosition = 'L';
            }
        }

        public void MoveRight()
        {
            lock (GameLogic.locker)
            {
                this.DrawLeftCar(' ');

                this.DrawRightCar(this.Symbol);

                MyCar.MyCarPosition = 'R';
            }
        }
    }
}
