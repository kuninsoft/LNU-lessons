using System;

namespace lab_1_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a floating-point number: ");
            
            var input = float.Parse(Console.ReadLine());
            var result = (float)Math.Sqrt(Math.Ceiling(input));

            Console.WriteLine($"Result is: {result}");

            Console.ReadKey();
        }
    }
}
