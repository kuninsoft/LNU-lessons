using System;

namespace lab_4_4
{
    class Rectangle : Figure, IDrawable
    {
        public Rectangle(float X, float Y) : base(X, Y)
        {

        }

        void IDrawable.Draw()
        {
            Console.WriteLine("Rectangle");
        }
    }
}
