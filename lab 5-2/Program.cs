using System;

namespace lab_5_2
{

    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect;
            string[] input;

            Console.Write("Enter rectangle width, height, x and y, separated by spaces: ");
            input = Console.ReadLine().Split(' ');

            rect = new Rectangle(double.Parse(input[0]), double.Parse(input[1]), double.Parse(input[2]), double.Parse(input[3]));

            Console.WriteLine($"Rectangle:\n\tWidth: {rect.Width}\n\tHeight: {rect.Height}\n\tPerimeter: {rect.Perimeter()}\n\tX: {rect.X}\n\tY: {rect.Y}");
            
            Console.ReadKey();
        }
    }
}
