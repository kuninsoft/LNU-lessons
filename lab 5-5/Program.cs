using System;

namespace lab_5_5
{
    public enum LongRange : long
    {
        Max = 9223372036854775807,
        Min = -9223372036854775808
    }

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
