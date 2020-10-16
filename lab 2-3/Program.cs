using System;

namespace lab_2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            char[] inputCharArray;

            Console.Write("Enter a string: ");
            input = Console.ReadLine();
            inputCharArray = input.ToCharArray();

            for (byte i = 0; i < inputCharArray.Length; i++)
            {
                if(inputCharArray[i] == 'a')
                {
                    inputCharArray[i] = 'u';
                }
            }

            input = new string(inputCharArray);

            Console.WriteLine($"String with 'a' replaced by 'u': {input}");

            Console.ReadKey();
        }
    }
}
