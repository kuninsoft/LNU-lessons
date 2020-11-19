using System;

namespace lab_6_1
{
    class Program
    {
        static int[] ToCube(int[] array)
        {
            var result = new int[array.Length];
            
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = (int)Math.Pow(array[i], 3);
            }

            return result;
        }
        
        static void Main(string[] args)
        {
            Console.Write("Enter integer numbers, separated by spaces: ");
            
            var input = Console.ReadLine().Split(' ');
            var array = new int[input.Length];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(input[i]);
            }

            var result = ToCube(array);

            Console.Write("Result: ");
            foreach (var element in result)
            {
                Console.Write($"{element} ");
            }

            Console.WriteLine();
        }
    }
}