using System;

namespace lab_1_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a prime number: ");
            
            var input = int.Parse(Console.ReadLine());
            var result = (float)input / 2;

            Console.WriteLine("Result is: {0:0.00}", Math.Round(result, 2));

            Console.ReadKey();
        }
    }
}
