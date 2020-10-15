using System;

namespace lab_1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            float edgeLength;
            float volume;

            Console.Write("Enter edge length: ");
            edgeLength = float.Parse(Console.ReadLine());
            volume = edgeLength * edgeLength * edgeLength;

            Console.WriteLine($"Volume of cube: {volume}");

            Console.ReadKey();
        }
    }
}
