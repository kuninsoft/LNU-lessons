using System;

namespace lab_2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string names;

            Console.Write("Enter user names, separated with commas: ");
            names = Console.ReadLine();
            Console.WriteLine($"Usernames in lowercase: {names.ToLower()}");

            Console.ReadKey();
        }
    }
}
