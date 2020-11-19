using System;

namespace lab_4_4
{
    class Program
    {
        static void DrawAll(params IDrawable[] array)
        {
            foreach(var drawable in array)
            {
                drawable.Draw();
            }
        }

        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle(2.1f, 3.4f);
            Square sq = new Square(1.1f, 5.3f);
            Figure fig = new Figure(2.1f, 1.1f);

            DrawAll(rect, sq, fig);
        }
    }
}
