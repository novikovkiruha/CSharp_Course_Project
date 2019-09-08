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

        private int[] coordinatesX;

        private int[] coordinatesY;

        public int Speed { get; }

        public int Score { get; }

        private char Symbol { get; }

        public ConsoleColor Color { get; }

        static public char MyCarPosition { get; set; }

        static public bool IsCrash { get; set; }

        public MyCar()
        {
            this.coordinatesX = new int[] { 6, 5, 6, 7, 6, 5, 7 };
            this.coordinatesY = new int[] { 16, 17, 17, 17, 18, 19, 19 };
            this.Speed = 250;
            this.Score = 0;
            this.Symbol = 'o';
            this.Color = ConsoleColor.Green;
            this.MoveRight();
        }

        protected virtual void OnCrashStatus(CrashStatusEventArgs e)
        {
            this.CrashStatus?.Invoke(this, e);
        }

        protected virtual void OnMyCarPosition(CrashStatusEventArgs e)
        {
            this.CrashStatus?.Invoke(this, e);
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
                    Thread.CurrentThread.Interrupt();
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

                this.OnCrashStatus(new CrashStatusEventArgs(MyCar.IsCrash));
            }
        }

        public void MoveRight()
        {
            lock (GameLogic.locker)
            {
                this.DrawLeftCar(' ');

                this.DrawRightCar(this.Symbol);

                MyCar.MyCarPosition = 'R';

                this.OnCrashStatus(new CrashStatusEventArgs(MyCar.IsCrash));
            }
        }
    }
}
