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

            //foreach (var folder in folders)
            //{
            //    //var size = folder.GetFiles().Length;
            //    try
            //    {
            //        string folderName = folder.Name;
            //        Console.WriteLine($"Folder Name: {folderName}");
            //        folderNumber++;
            //        if (folder.Name == folderName)
            //        {
            //            CountTotalSize(totalSize);
            //        }
            //        foreach (var file in folder.GetFiles())
            //        {
            //            totalSize += (double)file.Length / (1024 * 1024 * 1024);
            //            Console.WriteLine($"File Name: {file.Name}");
            //        }
            //        fileNumber = folder.GetFiles().Count();
            //    }
            //    catch (Exception)
            //    {
            //        Console.WriteLine("Couldn't define the size of the folder");
            //    }
            //}

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
                catch (Exception)
                {
                    Console.WriteLine("Couldn't define the size of the folder");
                }
            }
            Console.WriteLine(size);
            //foreach (var file in files)
            //{
            //    try
            //    {
            //        long totalSize = folders.EnumerateFiles().Sum(file => file.Length);
            //        totalSize = file;
            //        Console.WriteLine(file.Length);
            //    }
            //    catch (Exception)
            //    {
            //        Console.WriteLine("Couldn't define the size of the folder");
            //    }
            //}

            //Console.WriteLine(folders.Length);
            //var foldersNumber = folders.Count();
            //Console.WriteLine(foldersNumber);

            return size;
        }
    }
}
