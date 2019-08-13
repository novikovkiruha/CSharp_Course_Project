using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTask_CarRacing
{
    public class Renderer
    {
        public void Render()
        {
            var field = new Field();
            var car = new MyCar('*', ConsoleColor.White);

            field.StartX = field.Width - 1;
            field.StartY = field.Height - 1;

            //Console.SetCursorPosition(field.StartX, field.StartY);
            car.DrawMyCar(field.StartX, field.StartY);

            while (true)
            {
                var action = Console.ReadKey();

                switch (action.Key)
                {
                    case ConsoleKey.UpArrow:
                        car.MoveUp();
                        break;
                    case ConsoleKey.DownArrow:
                        car.MoveDown();
                        break;
                    case ConsoleKey.LeftArrow:
                        car.MoveLeft();
                        break;
                    case ConsoleKey.RightArrow:
                        car.MoveRight();
                        break;
                    case ConsoleKey.Escape:
                        break;
                }

                if (action.Key == ConsoleKey.Escape)
                    break;
            }
        }
    }
}
