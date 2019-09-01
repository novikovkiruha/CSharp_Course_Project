using System;
using System.Threading;

namespace SimpleRacing
{
    public class OtherCar
    {
        private Random random;

        private int[] coordinatesX;

        private int[] coordinatesY;

        private char Symbol { get; }

        public int Speed { get; }

        public char CarPosition { get; set; }

        public ConsoleColor Color { get; }

        public OtherCar(int speed)
        {
            this.random = new Random();
            this.coordinatesX = new int[] { 2, 4, 3, 2, 3, 4, 3 };
            this.coordinatesY = new int[] { 0, 0, 1, 2, 2, 2, 3 };
            this.Symbol = '*';
            this.Speed = speed;
            this.Color = ConsoleColor.Red;
        }

        public void MoveOtherCar(int fieldHeight)
        {
            while (true)
            {
                var otherCarPosition = this.random.Next(0, 2);
                var positionX = 3;
                int positionY = 0;
                int counter = 0;

                switch (otherCarPosition)
                {
                    case 0:
                        positionX = 0;
                        this.CarPosition = 'L';
                        break;
                    case 1:
                        positionX = 3;
                        this.CarPosition = 'R';
                        break;
                }

                for (int i = 0; i < fieldHeight - 3; i++)
                {
                    if (i != fieldHeight)
                    {
                        this.DrawOtherCar(this.Symbol, positionX, positionY);
                    }

                    Thread.Sleep(this.Speed);

                    if (i != fieldHeight)
                    {
                        this.DrawOtherCar(' ', positionX, positionY);
                    }

                    positionY++;
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
