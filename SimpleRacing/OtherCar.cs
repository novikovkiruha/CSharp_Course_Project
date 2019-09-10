using SimpleRacing.SimpleRacing;
using System;
using System.Threading;

namespace SimpleRacing
{
    public class OtherCar
    {
        private readonly Random random;

        private readonly int[] coordinatesX;

        private readonly int[] coordinatesY;

        private char Symbol { get; }

        public char OtherCarPosition { get; set; }

        public ConsoleColor Color { get; }

        public OtherCar()
        {
            this.random = new Random();
            this.coordinatesX = new int[] { 2, 4, 3, 2, 3, 4, 3 };
            this.coordinatesY = new int[] { 0, 0, 1, 2, 2, 2, 3 };
            this.Symbol = '*';
            this.Color = ConsoleColor.Blue;
        }

        public void MoveOtherCar(int fieldHeight)
        {
            while (true)
            {
                var otherCarPosition = this.random.Next(0, 2);
                var positionX = 3;
                int positionY = 0;

                switch (otherCarPosition)
                {
                    case 0:
                        positionX = 0;
                        break;
                    case 1:
                        positionX = 3;
                        break;
                }

                for (int i = 0; i < fieldHeight - 3; i++)
                {
                    if (i != fieldHeight)
                    {
                        this.DrawOtherCar(this.Symbol, positionX, positionY);
                    }

                    Thread.Sleep(Board.Speed);

                    if (i != fieldHeight)
                    {
                        this.DrawOtherCar(' ', positionX, positionY);
                    }

                    if (positionX == 0)
                    {
                        this.OtherCarPosition = 'L';
                    }
                    else if (positionX == 3)
                    {
                        this.OtherCarPosition = 'R';
                    }

                    positionY++;

                    if (positionY > 12)
                    {
                        if (this.OtherCarPosition == MyCar.MyCarPosition)
                        {
                            MyCar.IsCrash = true;
                        }
                    }
                }

                if (MyCar.IsCrash)
                {
                    Thread.CurrentThread.Suspend();
                }
            }
        }

        public void DrawOtherCar(char symbol, int positionX, int positionY)
        {
            lock (GameLogic.locker)
            {
                for (int j = 0; j < this.coordinatesX.Length; j++)
                {
                    Console.ForegroundColor = this.Color;
                    Console.SetCursorPosition(this.coordinatesX[j] + positionX, this.coordinatesY[j] + positionY);

                    Console.WriteLine(symbol);
                }
            }
        }
    }
}
