using System;
using practice_06._08._2019_System.IO.Task1_Folders;
using practice_06._08._2019_System.IO.Task2_FileCreation;
using practice_06._08._2019_System.IO.Task3_FileCharacters;

namespace practice_06._08._2019_System.IO
{
    class Program
    {
        static void Main(string[] args)
        {
            new FolderHelper().ShowFoldersAndSize();
            new FileCreator().CreateFile();
            new FileCharacters().DefineFileExistence(new FileCreator().tempFolder + new FileCreator().textFile);
        }
    }
}
