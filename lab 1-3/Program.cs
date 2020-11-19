using System;

namespace lab_1_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number and its power (separated by spaces): ");
            
            var numberAndPower = Console.ReadLine().Split(' ');
            var m = float.Parse(numberAndPower[0]);
            var n = float.Parse(numberAndPower[1]);

            var result = (float)Math.Pow(m, n);

            Console.WriteLine($"{m} to power {n} is {result}.");

            Console.ReadKey();
        }
    }
}
