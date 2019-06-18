using System;
using System.IO;
using System.Linq;

namespace practice_06._08._2019_System.IO.Task1_Folders
{
    public class Folder
    {
        public void ShowFolders()
        {
            var path = @"D:\Temp";
            //var path = @"C:\Windows\System32\";
            var folders = new DirectoryInfo(path).GetDirectories();
            //var folders = Directory.GetDirectories(path);
            var folderNumber = folders.Length;
            var files = new DirectoryInfo(path).GetFiles();
            var fileNumber = 0;
            double totalSize = 0;

            if (folderNumber == 0)
            {
                foreach (var file in files)
                {
                    totalSize += (double)file.Length / (1024 * 1024 * 1024);
                    Console.WriteLine($"File Name: {file.Name}");
                }
            }
            else
            {
                foreach (var folder in folders)
                {
                    double CountTotalFilesSize(double size)
                    {
                        totalSize = size + CountTotalFilesSize(size);
                        Console.WriteLine(totalSize);
                        return totalSize;
                    }
                }
            }

            Console.WriteLine($"Number of folders: {folderNumber}");
            Console.WriteLine($"Total size: {totalSize} GB");
            Console.WriteLine($"Number of files {fileNumber}");
        }

        public double CountTotalSize(double size)
        {
            var path = @"D:\";

            //var folders = Directory.GetDirectories(path, "*.*", SearchOption.AllDirectories);
            var folders = new DirectoryInfo(path).GetDirectories();

            foreach (var folder in folders)
            {
                try
                {
                    size = (double)folder.EnumerateFiles().Sum(fileSize => fileSize.Length) / (1024 * 1024 * 1024);
                    Console.WriteLine($"File: {folder.Name} - {size}");
                }
                catch (UnauthorizedAccessException)
                {
                    Console.WriteLine("Couldn't define the size of the folder");
                }
            }
            Console.WriteLine(size);

            return size;
        }

        public void Execute()
        {
            var path = @"D:\Films\";
            DirectoryInfo directory = new DirectoryInfo(path);
            int foldersNumber = directory.GetDirectories().Length;

            double size = 0;
            size = GetDirectorySize(directory, size);

            Console.WriteLine($"Number of directories is {foldersNumber}. Size: {Math.Round(size / (1024 * 1024 * 1024), 2)} GB"); // (1024 * 1024 * 1024)
        }

        public double GetDirectorySize(DirectoryInfo directoryPath, double size)
        {
            int counter = directoryPath.GetDirectories().Length;
            try
            {
                if (directoryPath.GetDirectories().Length > 0)
                {
                    foreach (var item in directoryPath.GetDirectories())
                    {
                        Console.WriteLine(item);
                        size += GetDirectorySize(item, size);
                    }
                }
                else if (directoryPath.GetDirectories().Length == 0)
                {
                    foreach (FileInfo file in directoryPath.GetFiles())
                    {
                        Console.WriteLine(file);
                        size += file.Length;
                    }
                }
            }
            catch (UnauthorizedAccessException ex)
            {
                Console.WriteLine(ex.Message);
            }

            return size;
        }
    }
}
