using System;
using System.Linq;

namespace lab_6_2
{
    class Program
    {
        static bool CheckIfPrime(int number)
        {
            if (number <= 1) return false;
            for (var i = 2; i < Math.Ceiling(Math.Sqrt(number)); i++)
            {
                if (number % i == 0) return false;
            }
            return true;
        }
        
        static void Main(string[] args)
        {
            Console.Write("Enter integer numbers, separated by spaces: ");
            
            var input = Console.ReadLine().Split(' ');
            var array = new int[input.Length];
            
            for (var i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(input[i]);
            }

            var count = array.Count(element => CheckIfPrime(element));

            Console.WriteLine($"There are {count} prime numbers in the array.");
        }
    }
}