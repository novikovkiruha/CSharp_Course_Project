using System;

namespace CSharp_Course_Project.Task3
{
    //Создайте статический класс с методом void Print(string stroka, int color),
    //который выводит на экран строку заданным цветом.
    //Используя перечисление, создайте набор цветов, доступных пользователю.
    //Ввод строки и выбор цвета предоставьте пользователю.

    public class PrintColor
    {
        public string GetInputText()
        {
            Console.WriteLine("Enter some text:");

            return Console.ReadLine();
        }

        public string GetChoosenColor()
        {
            Console.WriteLine("Enter one of the color from the list:");
            foreach (var value in Enum.GetValues(typeof(Colors)))
                Console.WriteLine(value);

            Console.WriteLine();
            string color = Console.ReadLine();

            return color;
        }

        public int GetNumberOfColors()
        {
            int count = 0;
            foreach (Colors s in Enum.GetValues(typeof(Colors)))
                count++;

            return count;
        }

        public void Print()
        {
            string text = GetInputText();
            string color = GetChoosenColor();

            foreach (var value in Enum.GetValues(typeof(Colors)))
            {
                if (color == value.ToString())
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(text);
                }
                else
                {
                    Console.WriteLine("Wrong value");
                    break;
                }
            }
        }
    }

    enum Colors
    {
        Red,
        Blue,
        Green,
        Yellow,
        Purple,
        White
    }
}
