using System;

namespace lab_6_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter array height and width MxN (e.g. 2x3): ");
            
            var input = Console.ReadLine().Split('x');
            var m = int.Parse(input[0]);
            var n = int.Parse(input[1]);
            var array = new int[m][];

            for (var i = 0; i < m; i++)
            {
                array[i] = new int[n];
                
                Console.WriteLine($"Enter {i + 1}th row elements, separated by spaces: ");
                
                input = Console.ReadLine().Split(' ');
                for (var j = 0; j < n; j++)
                {
                    array[i][j] = int.Parse(input[j]);
                }
            }

            var resultVector = new int[m];

            for (var i = 0; i < m; i++)
            {
                resultVector[i] = array[i][0];
                for (var j = 0; j < n; j++)
                {
                    if (resultVector[i] < array[i][j]) resultVector[i] = array[i][j];
                }
            }

            Console.Write("Vector, consisting of max values of every array row:\n ( ");
            foreach (var element in resultVector)
            {
                Console.Write($"{element} ");
            }
            Console.Write(")");
        }
    }
}