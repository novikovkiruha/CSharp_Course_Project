using practice_06._08._2019_System.IO.Task2_FileCreation;
using System;
using System.IO;

//Разработайте приложение, которое позволяет посчитать сколько содержится в файле символов, строк и слов.
//Разделителями слов считать пробелы и перенос строки.

namespace practice_06._08._2019_System.IO.Task3_FileCharacters
{
    public class FileCharacters
    {
        public void CountCharacters(string filePath)
        {
            string tempText = "";
            char[] charArray;
            string[] textArray;
            int wordCounter = 0;
            int lineCounter = 0;
            var file = new FileInfo(filePath);
            StreamReader reader = new StreamReader(file.FullName);
            tempText = reader.ReadToEnd();

            Console.WriteLine($"Text in file: {Environment.NewLine}{tempText}");
            using (reader = new StreamReader(file.FullName))
            {
                while (reader.ReadLine() != null)
                {
                    lineCounter++;
                }
            }
                //while (reader.EndOfStream != true)
                //    tempText += reader.ReadLine();

                charArray = tempText.ToCharArray();

            textArray = tempText.Split(' ');
            foreach (var item in textArray)
            {
                if (item == Environment.NewLine)
                    lineCounter++;
                if (item != String.Empty)
                    wordCounter++;
            }

            Console.WriteLine($"Chars number: {charArray.Length}");
            Console.WriteLine($"Words number: {wordCounter}");
            Console.WriteLine($"Lines number: {lineCounter}");

            reader.Close();
        }

        public void IsFileExist(string filePath)
        {
            if (File.Exists(filePath))
            {
                CountCharacters(filePath);
            }
            else
            {
                filePath = new FileCreation().CreateFile();
                CountCharacters(filePath);
            }
        }
    }
}
