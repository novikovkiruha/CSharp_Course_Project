using SimpleRacing.SimpleRacing;
using System;
using System.Threading;

namespace SimpleRacing
{
    public class GameLogic
    {
        private object locker = new object();

        private Field field;

        private MyCar myCar;

        private OtherCar otherCar;

        private Border border;

        public GameLogic()
        {
            this.field = new Field();
            this.myCar = new MyCar();
            this.otherCar = new OtherCar();
            this.border = new Border();
        }

        public void PlayGame()
        {
            Console.CursorVisible = false;

            new Thread(new ThreadStart(this.DrawBorder)).Start();
            new Thread(new ThreadStart(this.DrawMyCar)).Start();
            new Thread(new ThreadStart(this.DrawOtherCar)).Start();
        }

        public void DrawBorder()
        {
            this.border.MoveBorder(this.field.Height, this.field.Width);
        }

        public void DrawMyCar()
        {
            this.myCar.DrawStartCar();

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
    }
}
