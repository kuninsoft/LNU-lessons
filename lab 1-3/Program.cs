using System;

namespace lab_1_3
{
    class Program
    {
        static void Main(string[] args)
        {
            float m;
            float n;
            float result;

            Console.Write("Enter a number and its power (separated by spaces): ");
            string[] numberAndPower = Console.ReadLine().Split(' ');
            m = float.Parse(numberAndPower[0]);
            n = float.Parse(numberAndPower[1]);

            result = (float)Math.Pow(m, n);

            Console.WriteLine($"{m} to power {n} is {result}.");

            Console.ReadKey();
        }
    }
}
