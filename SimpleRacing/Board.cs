using System;

namespace SimpleRacing
{
    public class Board
    {
        private int score;

        private int speed;

        private int coordinateX;

        private int coordinateY;

        public ConsoleColor Color { get; }

        public Board(int speed, int score)
        {
            this.speed = speed;
            this.score = score;
            this.coordinateX = 15;
            this.coordinateY = 0;
            this.Color = ConsoleColor.White;
        }

        public void DrawBoard()
        {
            Console.ForegroundColor = this.Color;
            Console.SetCursorPosition(this.coordinateX, this.coordinateY);
            Console.WriteLine($"Score: {this.score}");
            Console.SetCursorPosition(this.coordinateX, this.coordinateY + 1);
            Console.WriteLine($"Speed: {this.speed}");
            this.score += 100;
        }
    }
}
