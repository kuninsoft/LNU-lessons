using System;

namespace lab_1_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int input;
            float result;
            
            Console.Write("Enter a prime number: ");
            
            input = int.Parse(Console.ReadLine());
            result = (float)input / 2;

            Console.WriteLine("Result is: {0:0.00}", Math.Round(result, 2));

            Console.ReadKey();
        }
    }
}
