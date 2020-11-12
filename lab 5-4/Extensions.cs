using System;

namespace lab_5_4
{
    public static class Extensions
    {
        public static void PrintColors(this Colors color)
        {
            // Getting values array of our enum and casting it to int[]
            int[] values = (int[])Enum.GetValues(color.GetType());

            Array.Sort(values);

            for (int i = 0; i < values.Length; i++)
            {
                Console.WriteLine("{0} = {1}", (Colors)values[i], values[i]);
            }
        }
    }

}
