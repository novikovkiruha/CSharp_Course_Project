using System;
using System.IO;


//Разработайте приложение, которое позволяет создавать текстовый файл по пути C:\Temp\userText.txt и записывать в него текст,
//полученный от пользователя.

namespace practice_06._08._2019_System.IO.Task2_FileCreation
{
    public class FileCreation
    {
        public void CreateFile()
        {
            var path = @"D:\";
            var tempFolder = @"D:\Temp\";
            var textFile = @"D:\Temp\SomeText.txt";
            var folders = Directory.GetDirectories(path);


            if (Directory.Exists(tempFolder))
            {
                Console.WriteLine("Temp folder is already exist");
                if (File.Exists(textFile))
                {
                    File.Delete(textFile);
                }
                File.Create(tempFolder + "Text.txt");
            }
            else
            {
                DirectoryInfo di = Directory.CreateDirectory(tempFolder);
                Console.WriteLine("Temp folder was created");
            }
        }

        public string WriteSomeText()
        {
            Console.WriteLine("Write some text");
            return Console.ReadLine();
        }
    }
}
