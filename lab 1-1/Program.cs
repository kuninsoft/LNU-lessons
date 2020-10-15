using System;

namespace lab_1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            float radius;
            float area;

            Console.Write("Enter radius: ");

            radius = float.Parse(Console.ReadLine());
            area = radius * radius * (float)Math.PI;

            Console.WriteLine("Area is: {0}", area);

            Console.ReadKey();
        }
    }
}
