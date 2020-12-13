using System;
using System.IO;

namespace lab_8_2
{
    class Program
    {
        // Повертає 0, коли файл знайдено, або -1, якщо файлу немає ні у папці, ні у підпапках.
        static int Search(DirectoryInfo directory, string fileName)
        {
            foreach (var file in directory.GetFiles($"*{fileName}*.txt"))
            {
                Console.Out.WriteLine("Found the file! Full path is: ");
                Console.Out.WriteLine($"{file.DirectoryName}\\{file}");
                return 0;
            }

            foreach (var subdirectory in directory.GetDirectories())
            {
                if (Search(subdirectory, fileName) == 0)
                {
                    return 0;
                }
            }

            return -1;
        }
        
        static void Main(string[] args)
        {
            Console.Out.Write("Enter name or part of name of file to find: ");
            var fileName = Console.ReadLine();
            
            Console.Out.Write("Enter directory in which to seek for the file (also will seek in all subdirectories). Leave blank to seek in current directory: ");
            var directoryName = Console.ReadLine();

            Console.Out.WriteLine("Note: will return the first occurence of the .txt file with this substring");

            if (string.IsNullOrEmpty(directoryName))
            {
                directoryName = Directory.GetCurrentDirectory();
            }
            
            var directory = new DirectoryInfo(directoryName);

            if (Search(directory, fileName) == -1)
            {
                Console.WriteLine("Unfortunately, file was not found in the directory nor subdirectories.");
            }
        }
    }
}