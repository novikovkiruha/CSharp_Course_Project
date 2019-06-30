using System;
using System.IO;
using System.Linq;

namespace practice_06._08._2019_System.IO.Task1_Folders
{
    public class FolderHelper
    {
        public void ShowFoldersAndSize()
        {
            var path = @"C:\Windows\System32";
            var directory = new DirectoryInfo(path);
            int foldersNumber = directory.GetDirectories().Length;

            double size = GetDirectorySize(directory);

            Console.WriteLine($"Number of directories is {foldersNumber}. Size: {Math.Round(size / (1024 * 1024 * 1024), 2)} GB"); // (1024 * 1024 * 1024)
        }

        public double GetDirectorySize(DirectoryInfo directoryPath)
        {
            double size = 0;
            int counter = 0;

            try
            {
                counter = directoryPath.GetDirectories().Length;

                foreach (var file in directoryPath.GetFiles())
                {
                    size += file.Length;
                }

                if (counter == 0)
                    return size;

                foreach (var item in directoryPath.GetDirectories())
                {
                    size += GetDirectorySize(item);
                }
            }
            catch (UnauthorizedAccessException e)
            {
                Console.WriteLine(e.Message);
            }

            return size;
        }
    }
}
