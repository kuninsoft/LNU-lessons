using System;

namespace lab_1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter edge length: ");
            var edgeLength = float.Parse(Console.ReadLine());
            var volume = edgeLength * edgeLength * edgeLength;

            Console.WriteLine($"Volume of cube: {volume}");

            Console.ReadKey();
        }
    }
}
