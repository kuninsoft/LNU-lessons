using System;

namespace lab_3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            float radius;

            Console.Write("Enter circle radius: ");
            radius = float.Parse(Console.ReadLine());

            Console.WriteLine($"Circle area is: {Circle.GetArea(radius)} \nCircle length is: {Circle.GetLength(radius)}");

            Console.ReadKey();
        }
    }
}
