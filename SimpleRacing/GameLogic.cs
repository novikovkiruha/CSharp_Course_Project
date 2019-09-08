using SimpleRacing.SimpleRacing;
using System;
using System.Threading;

namespace SimpleRacing
{
    public class GameLogic
    {
        public static object locker = new object();

        private readonly Field field;

        private MyCar myCar;

        private readonly OtherCar otherCar;

        private readonly OtherCar2 otherCar2;

        private readonly Border border;

        private readonly Board board;

        public GameLogic()
        {
            this.field = new Field();
            this.border = new Border();
            this.board = new Board();
            this.myCar = new MyCar();
            this.otherCar = new OtherCar();
            this.otherCar2 = new OtherCar2();
            this.myCar.CrashStatus += this.OnCrashStatusInvoked;
        }

        public void OnCrashStatusInvoked(object sender, CrashStatusEventArgs e)
        {

        }

        public void PlayGame()
        {
            Console.CursorVisible = false;

            var borderThread = new Thread(new ThreadStart(this.DrawBorder));
            var boardThread = new Thread(new ThreadStart(this.DrawBoard));
            var myCarThread = new Thread(new ThreadStart(this.DrawMyCar));
            var otherCarThread1 = new Thread(new ThreadStart(this.DrawOtherCar));
            var otherCarThread2 = new Thread(new ThreadStart(this.DrawOtherCar2));

            borderThread.Start();
            boardThread.Start();
            myCarThread.Start();
            otherCarThread1.Start();
            Thread.Sleep(Board.Speed * 9);
            otherCarThread2.Start();
            //otherCarThread2.Start();

            while (MyCar.IsCrash)
            {
                Console.WriteLine("Game Over");
                borderThread.Abort();
                myCarThread.Abort();
                otherCarThread1.Abort();
                otherCarThread2.Abort();
                boardThread.Abort();
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
                }
            }
        }

        public void DrawOtherCar()
        {
            this.otherCar.MoveOtherCar(this.field.Height);
        }

        public void DrawOtherCar2()
        {
            this.otherCar2.MoveOtherCar(this.field.Height);
        }

        public void DrawBoard()
        {
            this.board.DrawBoard();
        }
    }
}
