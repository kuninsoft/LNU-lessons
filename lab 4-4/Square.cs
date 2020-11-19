using System;

namespace lab_4_4
{
    class Square : Figure, IDrawable
    {
        public Square(float x, float y) : base(x, y)
        {

        }
        void IDrawable.Draw()
        {
            Console.WriteLine("Square");
        }
    }
}
