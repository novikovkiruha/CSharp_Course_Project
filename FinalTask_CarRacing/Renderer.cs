using System;

namespace FinalTask_CarRacing
{
    public class Renderer
    {
        public void Render()
        {
            Console.CursorVisible = false;

            var field = new Field();
            var car = new MyCar('*', ConsoleColor.Green);
            var border = new RoadBorder('V', ConsoleColor.White);

            field.StartX = field.Width - 1;
            field.StartY = field.Height - 1;

            for (int i = 0; i < field.Height + 3; i++)
            {
                if (i % 4 != 0 && i < field.Height)
                {
                    Console.SetCursorPosition(0, i);
                    Console.WriteLine(border.Symbol);
                    Console.SetCursorPosition(field.Width, i);
                    Console.WriteLine(border.Symbol);
                }
            }

            //Console.SetCursorPosition(field.StartX, field.StartY);
            car.DrawMyCar(field.StartX, field.StartY);

            while (true)
            {
                var action = Console.ReadKey();

                switch (action.Key)
                {
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
