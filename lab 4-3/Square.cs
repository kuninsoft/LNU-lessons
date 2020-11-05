using System;

namespace lab_4_3
{
    class Square : Figure
    {
        public Square(float X, float Y) : base(X, Y)
        {

        }
        public override void Draw()
        {
            Console.WriteLine("Square");
        }
    }
}
