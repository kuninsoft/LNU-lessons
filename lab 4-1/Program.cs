using System;

namespace lab_4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle();
            Square sq = new Square();

            sq.Draw();
            rect.Draw();

            Console.ReadKey();
        }
    }
}
