using System;

namespace lab_5_4
{
    public static class Extensions
    {
        public static void PrintColors(this Colors color)
        {
            // Getting values array of our enum and casting it to int[]
            var values = (int[])Enum.GetValues(color.GetType());

            Array.Sort(values);

            foreach (var t in values)
            {
                Console.WriteLine($"{(Colors)t} = {t}");
            }
        }
    }

}
