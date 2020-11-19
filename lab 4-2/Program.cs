using System;

namespace lab_4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle(2.1f, 3.4f);
            Square sq = new Square(1.1f, 5.3f);

            sq.Draw();
            rect.Draw();

            Console.WriteLine("Square:\n\t" +
                              $"X: {sq.X}\n\t" +
                              $"Y: {sq.Y}\n" + 
                              "Rectangle:\n\t" +
                              $"X: {rect.X}\n\t" +
                              $"Y: {rect.Y}");
        }
    }
}
