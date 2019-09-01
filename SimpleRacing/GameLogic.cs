using SimpleRacing.SimpleRacing;
using System;
using System.Threading;

namespace SimpleRacing
{
    public class GameLogic
    {
        public static object locker = new object();

        private Field field;

        private MyCar myCar;

        private OtherCar otherCar;

        private Border border;

        private Board board;

        public GameLogic()
        {
            this.field = new Field();
            this.myCar = new MyCar();
            this.otherCar = new OtherCar(this.myCar.Speed);
            this.border = new Border();
            this.board = new Board(this.otherCar.Speed, this.myCar.Score);
        }

        public void PlayGame()
        {
            Console.CursorVisible = false;

            var borderThread = new Thread(new ThreadStart(this.DrawBorder));
            var myCarThread = new Thread(new ThreadStart(this.DrawMyCar));
            var otherCarThread = new Thread(new ThreadStart(this.DrawOtherCar));
            var boardThread = new Thread(new ThreadStart(this.DrawBoard));

            borderThread.Start();
            myCarThread.Start();
            otherCarThread.Start();
            boardThread.Start();

            if (this.myCar.CarPosition == this.otherCar.CarPosition)
            {
                Console.WriteLine("Game Over");
                borderThread.Abort();
                myCarThread.Abort();
                otherCarThread.Abort();
            }
        }

        public void DrawBorder()
        {
            this.border.MoveBorder(this.field.Height, this.field.Width);
        }

        public void DrawMyCar()
        {
            while (true)
            {
                var action = Console.ReadKey();

                switch (action.Key)
                {
                    case ConsoleKey.LeftArrow:
                        myCar.MoveLeft();
                        break;
                    case ConsoleKey.RightArrow:
                        myCar.MoveRight();
                        break;
                    case ConsoleKey.Escape:
                        break;
                }

                if (action.Key == ConsoleKey.Escape)
                    break;
            }
        }

        public void DrawOtherCar()
        {
            this.otherCar.MoveOtherCar(this.field.Height);
        }

        public void DrawBoard()
        {
            this.board.DrawBoard();
        }
    }
}
