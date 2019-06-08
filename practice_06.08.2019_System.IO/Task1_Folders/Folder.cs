using System;
using System.IO;
using System.Linq;

namespace practice_06._08._2019_System.IO.Task1_Folders
{
    public class Folder
    {
        public void ShowFolders()
        {
            var path = @"D:\";
            //var path = @"C:\Windows\System32\";
            var folders = Directory.GetDirectories(path);
            var folderNumber = 0;
            long totalSize = 0;

            foreach (var item in folders)
            {
                try
                {
                    DirectoryInfo folder = new DirectoryInfo(item);
                    Console.WriteLine($"Folder Name: {folder.Name}");
                    folderNumber++;
                    foreach (var file in folder.GetFiles())
                    {
                        totalSize += file.Length;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Couldn't define the size of the folder");
                }
            }

            Console.WriteLine($"Number of folders: {folderNumber}");
            Console.WriteLine($"Total size: {totalSize}");
        }
    }
}
