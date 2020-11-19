using System;

namespace lab_4_4
{
    class Rectangle : Figure, IDrawable
    {
        public Rectangle(float x, float y) : base(x, y)
        {

        }

        void IDrawable.Draw()
        {
            Console.WriteLine("Rectangle");
        }
    }
}
