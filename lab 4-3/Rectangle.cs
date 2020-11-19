using System;

namespace lab_4_3
{
    class Rectangle : Figure
    {
        public Rectangle(float x, float y) : base(x, y)
        {

        }

        public override void Draw()
        {
            Console.WriteLine("Rectangle");
        }
    }
}
