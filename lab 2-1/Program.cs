using System;

namespace lab_2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter user names, separated with commas: ");
            var names = Console.ReadLine();
            Console.WriteLine($"Usernames in lowercase: {names.ToLower()}");

            Console.ReadKey();
        }
    }
}
