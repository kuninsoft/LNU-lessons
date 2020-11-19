using System;

namespace lab_5_2
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter rectangle width, height, x and y, separated by spaces: ");
            var input = Console.ReadLine().Split(' ');

            var rect = new Rectangle(double.Parse(input[0]),
                double.Parse(input[1]),
                double.Parse(input[2]),
                double.Parse(input[3]));

            Console.WriteLine(
                "Rectangle:\n\t" +
                $"Width: {rect.Width}\n\t" +
                $"Height: {rect.Height}\n\t" +
                $"Perimeter: {rect.Perimeter()}\n\t" +
                $"X: {rect.X}\n\t" +
                $"Y: {rect.Y}");
            
            Console.ReadKey();
        }
    }
}
