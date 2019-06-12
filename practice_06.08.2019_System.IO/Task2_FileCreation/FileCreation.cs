using System;
using System.IO;


//Разработайте приложение, которое позволяет создавать текстовый файл по пути C:\Temp\userText.txt и записывать в него текст,
//полученный от пользователя.

namespace practice_06._08._2019_System.IO.Task2_FileCreation
{
    public class FileCreation
    {
        public string tempFolder = @"D:\Temp\";

        public string textFile = "userText.txt";

        public string CreateFile()
        {
            try
            {
                if (Directory.Exists(this.tempFolder))
                {
                    Console.WriteLine($"{Path.GetDirectoryName(this.tempFolder)} folder is already exist");
                    WriteText(this.tempFolder, this.textFile);
                }
                else
                {
                    DirectoryInfo newFolder = Directory.CreateDirectory(this.tempFolder);
                    Console.WriteLine($"{newFolder.Name} folder was created");
                    WriteText(this.tempFolder, this.textFile);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return this.tempFolder + this.textFile;
        }

        public string WriteText(string path, string textFile)
        {
            if (File.Exists(path + textFile))
                File.Delete(path + textFile);
           
            Console.WriteLine("Write some text:");
            var inputText = Console.ReadLine();

            var writer = new StreamWriter(path + textFile, true);
            writer.WriteLine(inputText);
            writer.Close();
            Console.WriteLine($"{Path.GetFileName(textFile)} file with the following text was created: '{inputText}'");

            return inputText;
        }
    }
}
