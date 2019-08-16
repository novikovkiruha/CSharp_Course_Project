using SimpleRacing.SimpleRacing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleRacing
{
    public class GameLogic
    {
        static private object locker;

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

            //lock (locker)
            //{
                this.border.DrawBorder(this.field.Height, this.field.Width);
                this.myCar.DrawStartCar();
                this.otherCar.MoveOtherCar(this.field.Height);

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
            //}
        }
    }
}
