using System;

namespace lab_4_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle(2.1f, 3.4f);
            Square sq = new Square(1.1f, 5.3f);
            Figure fig = new Figure(2.1f, 1.1f);

            sq.Draw();
            rect.Draw();
            fig.Draw();
        }
    }
}
