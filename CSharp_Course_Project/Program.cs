using System;
using System.Text;

namespace CSharp_Course_Project
{
    public class Program
    {
        //Оставить в строке только один экземпляр каждого встречающегося символа.
        public static void UniqueSymbols()
        {
            Console.WriteLine("Enter some text:");
            var text = new StringBuilder(Console.ReadLine());

            for (int i = 0; i < text.Length; i++)
            {
                for (int j = 0; j < text.Length; j++)
                {
                    if (text[i] == text[j] && i != j)
                    {
                        Console.WriteLine(text.Remove(j, 1));
                    }
                }
            }
        }

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
            Console.WriteLine("Original text:");
            string text = "Why're you seeing so serious? Ha ? WHAT'RE YOU LOOKING FOR?";
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

            //
            // 2nd option
            //
            text = "Why're you seeing so serious? Ha? WHAT'RE YOU LOOKING FOR?";
            newText = "";
            int questionIndex1 = text.IndexOf('?');
            int questionIndex2 = text.IndexOf('?', questionIndex1 + 1);
            for (int i = questionIndex1; i < questionIndex2; i++)
            {
                if (text[i] != ' ')
                {
                    newText += text[i];
                }
            }
            string oldPart = text.Substring(questionIndex1, questionIndex2 - questionIndex1);
            Console.WriteLine(text.Replace(oldPart, newText));
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
        public static void InvertedStringArray() // 7
        {
            string text = "Why're you seeing so serious? Ha?";
            string[] array = text.Split(' ');
            string invertedText = "";
            for (int i = array.Length - 1; i >= 0; i--)
            {
                invertedText += array[i] + ' ';
            }
            Console.WriteLine(invertedText.Trim());
        }

        //В строке, состоящей из слов, разделенных пробелами, определить длину кратчайшего и самого длинного слов.
        public static void ShortestAndLongestWords()
        {
            Console.WriteLine("Enter some text:");
            string inputText = Console.ReadLine();
            string[] inputTextArray = inputText.Split(' ');
            string shortestWord = "";
            int min = inputTextArray[0].Length;
            string longestWord = "";
            int max = inputTextArray[0].Length;

            for (int i = 0; i < inputTextArray.Length; i++)
            {
                if (inputTextArray[i].Length < min)
                {
                    min = inputTextArray[i].Length;
                    shortestWord = inputTextArray[i];
                }
                else
                {
                    max = inputTextArray[i].Length;
                    longestWord = inputTextArray[i];
                }
            }
            Console.WriteLine($"Shortest word is \"{shortestWord}\" with {min} letter(s)\nLongest word is \"{longestWord}\" with {max} letter(s)");
        }

        static void Main(string[] args)
        {
            UniqueSymbols();
            //ExactSymbol();
            //StringInput();
            //SpacesBetweenQuestions();
            //SpacesDeleting();
            //FirstWordSymbol();
            //InvertedStringArray();
            //ShortestAndLongestWords();
        }
    }
}