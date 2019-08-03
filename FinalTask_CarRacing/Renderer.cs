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
            var car = new MyCar('*', ConsoleColor.White);
            Console.SetCursorPosition(1, 0);
            Console.WriteLine("*");
            Console.SetCursorPosition(0, 1);
            Console.WriteLine("*");
            Console.SetCursorPosition(1, 1);
            Console.WriteLine("*");
            Console.SetCursorPosition(2, 1);
            Console.WriteLine("*");
            Console.SetCursorPosition(1, 2);
            Console.WriteLine("*");
            Console.SetCursorPosition(0, 3);
            Console.WriteLine("*");
            Console.SetCursorPosition(2, 3);
            Console.WriteLine("*");
        }
    }
}
