using System;

namespace lab_5_1
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter person's name, surname and age, separated by spaces: ");
            var input = Console.ReadLine().Split(' ');

            var person = new Person(input[0], input[1], byte.Parse(input[2]));

            Console.Write("Enter random number N (N > 0): ");
            var n = byte.Parse(Console.ReadLine());

            Console.WriteLine(person.IsOlderThan(n));

            Console.ReadKey();
        }
    }
}
