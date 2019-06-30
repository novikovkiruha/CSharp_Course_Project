using practice_06._08._2019_System.IO.Task2_FileCreation;
using System;
using System.IO;

namespace practice_06._08._2019_System.IO.Task3_FileCharacters
{
    public class FileCharacters
    {
        public void CountCharacters(string filePath)
        {
            string tempText = string.Empty;
            char[] charArray;
            string[] textArray;
            int wordCounter = 0;
            int lineCounter = 0;
            var file = new FileInfo(filePath);
            var reader = new StreamReader(file.FullName);
            tempText = reader.ReadToEnd();

            Console.WriteLine($"Text in file: {Environment.NewLine}{tempText}");
            using (reader = new StreamReader(file.FullName))
            {
                while (reader.ReadLine() != null)
                {
                    lineCounter++;
                }
            }
                
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

        public void DefineFileExistence(string filePath)
        {
            if (File.Exists(filePath))
            {
                CountCharacters(filePath);
            }
            else
            {
                filePath = new FileCreator().CreateFile();
                CountCharacters(filePath);
            }
        }
    }
}
