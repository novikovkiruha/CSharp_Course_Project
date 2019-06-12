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
            //new Folder().ShowFolders();
            //new Folder().CountTotalSize(0);
            //new FileCreation().CreateFile();
            new FileCharacters().IsFileExist(new FileCreation().tempFolder + new FileCreation().textFile);
        }
    }
}
