using System;
using System.IO;
using System.Linq;

namespace lab_8_1
{
    class Program
    {
        static void ShowDirectoryContents(DirectoryInfo directory, int depth)
        {
            foreach (var subdirectory in directory.GetDirectories())
            {
                Console.Out.Write(string.Concat(Enumerable.Repeat(" ", depth)));
                Console.Out.WriteLine($"> {subdirectory}");
                ShowDirectoryContents(subdirectory, depth + 1);
            }

            foreach (var file in directory.GetFiles())
            {
                Console.Out.Write(string.Concat(Enumerable.Repeat(" ", depth)));
                Console.Out.WriteLine($"> {file}");
            }
        }
        
        static void Main(string[] args)
        {
            Console.Out.Write("Enter directory: ");
            var directoryPath = Console.ReadLine();
            var directory = new DirectoryInfo(directoryPath);

            Console.Out.WriteLine($"Contents of directory {directory}:");
            ShowDirectoryContents(directory, 0);
        }
    }
}