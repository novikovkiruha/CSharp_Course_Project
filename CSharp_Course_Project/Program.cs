using System;

namespace CSharp_Course_Project
{
    class Program
    {
        //Оставить в строке только один экземпляр каждого встречающегося символа.

        //Определить, как часто встречается определенный символ в строке.
        public static void ExactSymbol() // 2
        {
            Console.WriteLine("Enter some text:");
            string text = Console.ReadLine();
            Console.Write("Enter the symbol that you want to find: ");
            char symbol = Convert.ToChar(Console.ReadLine());
            int counter = 0;

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == symbol)
                {
                    counter++;
                }
            }
            Console.WriteLine($"The symbol '{symbol}' appears {counter} time(s)");
        }

        //Вставить в заданную позицию строки другую строку.

        //Во введенной строке удалить пробелы между первым и вторым вопросительным знаком.

        //Удалить в строке все лишние пробелы.
        //Лишними считаются пробелы, следующие непосредственно за пробелами. Т.е.между словами всегда должен находиться один пробел.

        //Найти слово, стоящее в тексте под определенным номером, и вывести его первую букву.

        //Вводится строка слов.Вывести слова в обратном порядке.

        //В строке, состоящей из слов, разделенных пробелами, определить длину кратчайшего и самого длинного слов.


        static void Main(string[] args)
        {
            ExactSymbol();
        }
    }
}