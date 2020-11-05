using System;

namespace lab_4_4
{
    class Square : Figure, IDrawable
    {
        public Square(float X, float Y) : base(X, Y)
        {

        }
        void IDrawable.Draw()
        {
            Console.WriteLine("Square");
        }
    }
}
