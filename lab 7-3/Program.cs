using System;
using System.Collections.Generic;

namespace lab_7_3
{
    internal class Program
    {
        private static List<string> strings = new List<string>(150);

        private static void DisplayPage(int pageNumber)
        {
            if (pageNumber > 0)
            {
                for (var i = 0; i < 5 && (pageNumber - 1) * 5 + i < strings.Count; i++)
                {
                    Console.Out.WriteLine(strings[(pageNumber - 1) * 5 + i]);
                }

                return;
            }
            Console.Out.WriteLine("You entered a non-positive number. Try anything else.");
        }

        private static void Main(string[] args)
        {
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            var randomNumber = new Random();

            for (var i = 0; i < 150; i++)
                strings.Add(
                    new string(
                        new[]
                        {
                            chars[randomNumber.Next(0, 26)],
                            chars[randomNumber.Next(0, 26)],
                            chars[randomNumber.Next(0, 26)],
                            chars[randomNumber.Next(0, 26)]
                        }
                    )
                );

            Console.Out.WriteLine($"Before formatting: {strings.Count}");

            // Видаляємо всі елементи які починаються з "Z", передаючи предикат (лямбда-вираз) який визначає, чи
            // починається елемент з Z.
            strings.RemoveAll(s => s[0] == 'Z');

            // Перетворюємо в HashSet, який не має елементів-дублікатів по своїй суті, а потім конвертуємо назад.
            var withoutDuplicates = new HashSet<string>(strings);
            strings = new List<string>(withoutDuplicates);
            withoutDuplicates.Clear();

            // Щоб відсортувати в порядку спадання, порівнюємо другу стрічку з першою, а не першу з другою.
            strings.Sort((s1, s2) => string.Compare(s2, s1, StringComparison.InvariantCultureIgnoreCase));

            Console.Out.WriteLine($"After formatting: {strings.Count}");

            while (true) {
                try
                {
                    Console.Out.Write("Enter page number: ");
                    DisplayPage(int.Parse(Console.ReadLine()));
                }
                // Якщо введене "число" насправді не число, нам викине System.FormatException, тому ми відловлюємо саме його.
                catch (FormatException)
                {
                    return;
                }
            }
        }
    }
}