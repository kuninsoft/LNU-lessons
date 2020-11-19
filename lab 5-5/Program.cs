using System;

namespace lab_5_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Max long value: {(long)LongRange.Max}");
            Console.WriteLine($"Min long value: {(long)LongRange.Min}");

            Console.ReadKey();
        }
    }
}
