using System;

namespace lab_6_3
{
    class Program
    {
        static bool CheckIfSymmetrical(int[] array)
        {
            if (array.Length == 1 || array.Length == 0)
            {
                return true;
            }

            if (array[0] == array[^1])
            {
                return CheckIfSymmetrical(new ArraySegment<int>(array, 1, array.Length - 2).ToArray());
            }
            
            return false;
        }
        
        static void Main(string[] args)
        {
            Console.Write("Enter array of integers, separated by commas (e.g. 1,2,1): ");
            
            var input = Console.ReadLine().Split(',');
            var array = new int[input.Length];

            for (var i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(input[i]);
            }

            var isSymmetrical = CheckIfSymmetrical(array);
            Console.WriteLine(isSymmetrical ? "Array is symmetrical" : "Array is asymmetrical");
        }
    }
}