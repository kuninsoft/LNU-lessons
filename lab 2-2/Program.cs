using System;

namespace lab_2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter two surnames, separated by commas: ");
            var surnames = Console.ReadLine().Split(',');
            
            if (surnames[0].Equals(surnames[1], StringComparison.InvariantCultureIgnoreCase))
            {
                Console.WriteLine("Surnames are equal.");
            }
            else
            {
                Console.WriteLine("Surnames are not equal.");
            }

            if (surnames[0].Length == surnames[1].Length)
            {
                Console.WriteLine("Surnames have equal lengths.");
            }
            else if (surnames[0].Length > surnames[1].Length)
            {
                Console.WriteLine("First surname is longer than second.");
            }
            else
            {
                Console.WriteLine("Second surname is longer than first.");
            }

            if(surnames[0][0] == surnames[1][0] &&
                surnames[0][surnames[0].Length - 1] == surnames[1][surnames[1].Length - 1])
            {
                Console.WriteLine("First and last characters in both strings are the same.");
            }
            else
            {
                Console.WriteLine("First or/and last characters in both strings are NOT the same.");
            }

            Console.ReadKey();

        }
    }
}
