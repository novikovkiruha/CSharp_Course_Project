using SimpleRacing.SimpleRacing;
using System;
using System.Threading;

namespace SimpleRacing
{
    public class Board
    {
        private int score;

        private readonly int coordinateX;

        private readonly int coordinateY;

        static public int Speed { get; set; }

        public ConsoleColor Color { get; }

        public Board()
        {
            Board.Speed = 250;
            this.score = 0;
            this.coordinateX = 15;
            this.coordinateY = 0;
            this.Color = ConsoleColor.White;
        }

        public void DrawBoard()
        {
            int speedDisplay = Board.Speed;

            while (true)
            {
                Thread.Sleep(100);

                lock (GameLogic.locker)
                {
                    Console.ForegroundColor = this.Color;
                    Console.SetCursorPosition(this.coordinateX, this.coordinateY);
                    Console.WriteLine($"Score: {this.score}");
                    Console.SetCursorPosition(this.coordinateX, this.coordinateY + 1);
                    Console.WriteLine($"Speed: {speedDisplay}");

                    this.score += 100;

                    if (this.score < 50000 && this.score % 10000 == 0 && Board.Speed > 50)
                    {
                        Board.Speed -= 25;
                        speedDisplay += 50;
                    }
                    else if (this.score % 25000 == 0 && Board.Speed > 50)
                    {
                        Board.Speed -= 25;
                        speedDisplay += 50;
                    }

                    if (MyCar.IsCrash)
                    {
                        Console.SetCursorPosition(this.coordinateX, this.coordinateY + 10);
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Game Over");
                        Thread.CurrentThread.Suspend();
                    }
                }
            }
        }
    }
}
