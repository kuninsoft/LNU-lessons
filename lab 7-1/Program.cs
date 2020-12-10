using System;
using System.Collections.Generic;
using System.IO;

namespace lab_7_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var people = new List<Person>
            {
                new Person
                {
                    Name = "Jonathan",
                    Age = 20, 
                    PhoneNumbers = new List<string> {"+380(63)000-00-01", "+380(63)000-00-02", "+380(63)000-00-03"}
                },
                new Person
                {
                    Name = "Joseph",
                    Age = 18, 
                    PhoneNumbers = new List<string> {"+380(63)030-00-11", "+380(63)066-00-12", "+380(63)405-50-13"}
                },
                new Person
                {
                    Name = "Jotaro",
                    Age = 17, 
                    PhoneNumbers = new List<string> {"+380(63)184-20-21", "+380(63)340-10-02", "+380(63)003-25-23"}
                },
                new Person
                {
                    Name = "Josuke",
                    Age = 16, 
                    PhoneNumbers = new List<string> {"+380(63)199-93-01", "+380(63)547-20-02", "+380(63)744-66-28"}
                },
                new Person
                {
                    Name = "Giorno",
                    Age = 15, 
                    PhoneNumbers = new List<string> {"+380(63)346-00-01", "+380(63)346-22-02", "+380(63)346-30-23"}
                },
                new Person
                {
                    Name = "Jolyne",
                    Age = 19, 
                    PhoneNumbers = new List<string> {"+380(63)101-01-11", "+380(63)111-11-02", "+380(63)111-11-13"}
                },
            };

            foreach (var person in people)
            {
                Console.Out.WriteLine($"Name: {person.Name}\nAge:{person.Age}\n");
            }
        }
    }
}