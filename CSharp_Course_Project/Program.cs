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
        public static void StringInput() // 3
        {
            Console.WriteLine("Enter the first text:");
            string firstText = Console.ReadLine();
            Console.WriteLine("Enter the second text:");
            string secondText = Console.ReadLine();
            Console.Write("Enter the index of the first string: ");
            int index = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(firstText.Insert(index, secondText));
        }

        //Во введенной строке удалить пробелы между первым и вторым вопросительным знаком.
        public static void SpacesBetweenQuestions() // 4
        {
            string text = "Why're you seeing so serious? Ha? WHAT'RE YOU LOOKING FOR?";
            int questionIndex = 0;

            string newText = "";
            int counter = 0;
            while (text[counter] != '?')
            {
                newText += text[counter];
                counter++;
                questionIndex = counter;
            }

            for (int i = questionIndex; i < text.Length; i++)
            {
                if (text[i] != ' ')
                {
                    newText += text[i];
                }
            }
            text = newText;
            Console.WriteLine(text);
        }

        //Удалить в строке все лишние пробелы.
        //Лишними считаются пробелы, следующие непосредственно за пробелами. Т.е.между словами всегда должен находиться один пробел.
        public static void SpacesDeleting() // 5
        {
            string text = " some   text     is  here  ";

            //
            // 1st option
            //
            string[] textWithoutExtraSpaces = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine($"|{string.Join(" ", textWithoutExtraSpaces)}|");

            //
            // 2nd option
            //
            string newText = "";
            string[] array = text.Split(' ');
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] != "")
                {
                    newText += array[i] + ' ';
                }
            }
            text = newText;
            Console.WriteLine($"|{text.Trim()}|");
        }

        //Найти слово, стоящее в тексте под определенным номером, и вывести его первую букву.
        public static void FirstWordSymbol() // 6
        {
            string text = "Why're you seeing so serious? Ha?";
            string[] array = text.Split(' ');
            Console.Write("Enter the index of the first string: ");
            int index = Convert.ToInt32(Console.ReadLine());
            if (index > array.Length)
            {
                Console.WriteLine("Index is outside the array. Try again...");
            }

            Console.WriteLine(text);
            for (int i = 0; i < array.Length; i++)
            {
                if (i == index)
                {
                    Console.WriteLine(array[i].Substring(0, 1));
                }
            }
        }

        //Вводится строка слов. Вывести слова в обратном порядке.

        //В строке, состоящей из слов, разделенных пробелами, определить длину кратчайшего и самого длинного слов.


        static void Main(string[] args)
        {
            //ExactSymbol();
            //StringInput();
            //SpacesBetweenQuestions();
            SpacesDeleting();
            //FirstWordSymbol();
        }
    }
}