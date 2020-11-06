using System;

namespace lab_5_1
{

    class Program
    {
        static void Main(string[] args)
        {
            Person person;
            string[] input;
            byte n;

            Console.Write("Enter person's name, surname and age, separated by spaces: ");
            input = Console.ReadLine().Split(' ');

            person = new Person(input[0], input[1], byte.Parse(input[2]));

            Console.Write("Enter random number N (N > 0): ");
            n = byte.Parse(Console.ReadLine());

            Console.WriteLine(person.isOlderThan(n));

            Console.ReadKey();
        }
    }
}
