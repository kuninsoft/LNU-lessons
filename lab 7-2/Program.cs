using System;
using System.Collections.Generic;

namespace lab_7_2
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
            
            people.AddRange(new List<Person>
            {
                new Person
                {
                    Name = "Dio",
                    Age = 13,
                    PhoneNumbers = new List<string>{"+380(67)222-33-11", "+380(67)336-61-21", "+380(67)336-61-25"}
                },
                new Person
                {
                    Name = "Kira",
                    Age = 33,
                    PhoneNumbers = new List<string>{"+380(68)234-11-31", "+380(73)211-51-35", "+380(55)843-42-63"}
                }
            });

            foreach (var person in people)
            {
                Console.Out.WriteLine($"{person.Name}'s phone numbers:");
                foreach (var phoneNumber in person.PhoneNumbers)
                {
                    Console.Out.WriteLine(phoneNumber);
                }
                Console.Out.WriteLine("");
            }
        }
    }
}