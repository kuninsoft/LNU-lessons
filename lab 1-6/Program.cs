using System;

namespace lab_1_6
{
    class Program
    {
        static void Main(string[] args)
        {
            float input;
            float result;

            Console.Write("Enter a floating-point number: ");
            input = float.Parse(Console.ReadLine());

            result = (float)Math.Sqrt(Math.Ceiling(input));

            Console.WriteLine($"Result is: {result}");

            Console.ReadKey();
        }
    }
}
