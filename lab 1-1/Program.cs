using System;

namespace lab_1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter radius: ");

            var radius = float.Parse(Console.ReadLine());
            var area = radius * radius * (float)Math.PI;

            Console.WriteLine("Area is: {0}", area);

            Console.ReadKey();
        }
    }
}
