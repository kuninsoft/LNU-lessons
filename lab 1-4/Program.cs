using System;

namespace lab_1_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a floating-point number: ");
            var input = float.Parse(Console.ReadLine());

            Console.WriteLine($"Integral part: {Math.Truncate(input)}. Rounded: {Math.Round(input)}.");

            Console.ReadKey();
        }
    }
}
