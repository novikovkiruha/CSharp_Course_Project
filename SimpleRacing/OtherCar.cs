using System;
using System.Threading;

namespace SimpleRacing
{
    public class OtherCar
    {
        private object locker = new object();

        private Random random;

        public char Symbol { get; }

        public int[] coordinatesX;

        public int[] coordinatesY;

        private int speed;

        public ConsoleColor Color { get; }

        public OtherCar()
        {
            this.random = new Random();
            this.Symbol = '*';
            this.coordinatesX = new int[] { 2, 4, 3, 2, 3, 4, 3 };
            this.coordinatesY = new int[] { 0, 0, 1, 2, 2, 2, 3 };
            this.speed = 250;
            this.Color = ConsoleColor.Red;
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
                    this.DrawOtherCar(this.Symbol, positionX, positionY);

                    Thread.Sleep(this.speed);

                    if (i != fieldHeight - 4)
                    {
                        this.DrawOtherCar(' ', positionX, positionY);
                    }

                    positionY++;
                }
            }
        }

        public void DrawOtherCar(char symbol, int positionX, int positionY)
        {
            lock (locker)
            {
                for (int j = 0; j < 7; j++)
                {
                    Console.ForegroundColor = this.Color;
                    Console.SetCursorPosition(this.coordinatesX[j] + positionX, this.coordinatesY[j] + positionY);

                    Console.WriteLine(symbol);
                }
            }
        }
    }
}
